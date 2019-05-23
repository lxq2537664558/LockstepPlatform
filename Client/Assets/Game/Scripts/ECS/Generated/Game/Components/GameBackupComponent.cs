//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Lockstep.ECS.Game.BackupComponent backup { get { return (Lockstep.ECS.Game.BackupComponent)GetComponent(GameComponentsLookup.Backup); } }
    public bool hasBackup { get { return HasComponent(GameComponentsLookup.Backup); } }

    public void AddBackup(uint newLocalEntityId, int newTick) {
        var index = GameComponentsLookup.Backup;
        var component = CreateComponent<Lockstep.ECS.Game.BackupComponent>(index);
        component.localEntityId = newLocalEntityId;
        component.tick = newTick;
        AddComponent(index, component);
    }

    public void ReplaceBackup(uint newLocalEntityId, int newTick) {
        var index = GameComponentsLookup.Backup;
        var component = CreateComponent<Lockstep.ECS.Game.BackupComponent>(index);
        component.localEntityId = newLocalEntityId;
        component.tick = newTick;
        ReplaceComponent(index, component);
    }

    public void RemoveBackup() {
        RemoveComponent(GameComponentsLookup.Backup);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherBackup;

    public static Entitas.IMatcher<GameEntity> Backup {
        get {
            if (_matcherBackup == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Backup);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBackup = matcher;
            }

            return _matcherBackup;
        }
    }
}
