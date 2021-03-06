using DesperateDevs.Utils;
using Entitas;
using Lockstep.Math;

namespace Lockstep.Game.Systems.Game {
    public class SystemDelayCall : BaseSystem, IExecuteSystem {
        readonly IGroup<GameEntity> _delayGroup;

        public SystemDelayCall(Contexts contexts, IServiceContainer serviceContainer):base(contexts,serviceContainer) {
            _delayGroup = contexts.game.GetGroup(GameMatcher.AllOf(
                GameMatcher.LocalId,
                GameMatcher.DelayCall));
        }


        public void Execute(){
            foreach (var entity in _delayGroup.GetEntities()) {
                if(entity.isDestroyed) return;
                var delayCall = entity.delayCall;
                delayCall.delayTimer -= GameConfig.DeltaTime;
                if (delayCall.delayTimer <= LFloat.zero) {
                    entity.isDestroyed = true;
                    delayCall.callBack?.Invoke();
                }
            }
        }
    }
}