namespace Lockstep.Serialization {

    [System.Serializable]
    public partial  class BaseFormater : ISerializable {
        
        public virtual void Serialize(Serializer writer){}
        public virtual void Deserialize(Deserializer reader){}
    }
}