using Lockstep.Serialization;

namespace NetMsg.Game {
    [System.Serializable]
    public partial class ServerFrame : BaseFormater {
        public byte[] inputDatas; //包含玩家的输入& 游戏输入
        public int tick;
        private Msg_PlayerInput[] _inputs;

        public Msg_PlayerInput[] Inputs {
            get { return _inputs; }
            set {
                _inputs = value;
                inputDatas = null;
            }
        }

        private byte[] _serverInputs;
        
        public byte[] ServerInputs {//服务器输入 如掉落等
            get { return _serverInputs; }
            set {
                _serverInputs = value;
                inputDatas = null;
            }
        }

        public void BeforeSerialize(){
            if (inputDatas != null) return;
            var writer = new Serializer();
            var inputLen = (byte) (Inputs?.Length ?? 0);
            writer.Put(inputLen);
            for (byte i = 0; i < inputLen; i++) {
                var cmds = Inputs[i].Commands;
                var len = (byte) (cmds?.Length ?? 0);
                writer.Put(len);
                for (int cmdIdx = 0; cmdIdx < len; cmdIdx++) {
                    cmds[cmdIdx].Serialize(writer);
                }
            }

            writer.PutBytes_255(_serverInputs);
            inputDatas = writer.CopyData();
        }

        public void AfterDeserialize(){
            var reader = new Deserializer(inputDatas);
            var inputLen = reader.GetByte();
            _inputs = new Msg_PlayerInput[inputLen];
            for (byte i = 0; i < inputLen; i++) {
                var input = new Msg_PlayerInput();
                input.Tick = tick;
                input.ActorId = i;
                _inputs[i] = input;
                var len = reader.GetByte();
                if (len == 0) {
                    input.Commands = null;
                    continue;
                }

                input.Commands = new InputCmd[len];
                for (int cmdIdx = 0; cmdIdx < len; cmdIdx++) {
                    var cmd = new InputCmd();
                    cmd.Deserialize(reader);
                    input.Commands[cmdIdx] = cmd;
                }
            }

            _serverInputs = reader.GetBytes_255();
        }

        public override void Serialize(Serializer writer){
            BeforeSerialize();
            writer.Put(tick);
            writer.PutBytes_65535(inputDatas);
        }

        public override void Deserialize(Deserializer reader){
            tick = reader.GetInt();
            inputDatas = reader.GetBytes_65535();
            AfterDeserialize();
        }

        public override string ToString(){
            var count = (inputDatas == null) ? 0 : inputDatas.Length;
            return
                $"t:{tick} " +
                $"inputNum:{count}";
        }

        public override bool Equals(object obj){
            if (obj == null) return false;
            var frame = obj as ServerFrame;
            return Equals(frame);
        }

        public override int GetHashCode(){
            return tick;
        }

        public bool Equals(ServerFrame frame){
            if (frame == null) return false;
            if (tick != frame.tick) return false;
            BeforeSerialize();
            frame.BeforeSerialize();
            return inputDatas.EqualsEx(frame.inputDatas);
        }
    }
}