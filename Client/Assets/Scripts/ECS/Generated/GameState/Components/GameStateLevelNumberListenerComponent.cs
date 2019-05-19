//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public LevelNumberListenerComponent levelNumberListener { get { return (LevelNumberListenerComponent)GetComponent(GameStateComponentsLookup.LevelNumberListener); } }
    public bool hasLevelNumberListener { get { return HasComponent(GameStateComponentsLookup.LevelNumberListener); } }

    public void AddLevelNumberListener(System.Collections.Generic.List<ILevelNumberListener> newValue) {
        var index = GameStateComponentsLookup.LevelNumberListener;
        var component = CreateComponent<LevelNumberListenerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceLevelNumberListener(System.Collections.Generic.List<ILevelNumberListener> newValue) {
        var index = GameStateComponentsLookup.LevelNumberListener;
        var component = CreateComponent<LevelNumberListenerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveLevelNumberListener() {
        RemoveComponent(GameStateComponentsLookup.LevelNumberListener);
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
public sealed partial class GameStateMatcher {

    static Entitas.IMatcher<GameStateEntity> _matcherLevelNumberListener;

    public static Entitas.IMatcher<GameStateEntity> LevelNumberListener {
        get {
            if (_matcherLevelNumberListener == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.LevelNumberListener);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherLevelNumberListener = matcher;
            }

            return _matcherLevelNumberListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public void AddLevelNumberListener(ILevelNumberListener value) {
        var listeners = hasLevelNumberListener
            ? levelNumberListener.value
            : new System.Collections.Generic.List<ILevelNumberListener>();
        listeners.Add(value);
        ReplaceLevelNumberListener(listeners);
    }

    public void RemoveLevelNumberListener(ILevelNumberListener value, bool removeComponentWhenEmpty = true) {
        var listeners = levelNumberListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveLevelNumberListener();
        } else {
            ReplaceLevelNumberListener(listeners);
        }
    }
}
