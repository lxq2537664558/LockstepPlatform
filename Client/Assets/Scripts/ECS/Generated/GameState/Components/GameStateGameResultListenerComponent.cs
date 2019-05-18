//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public GameResultListenerComponent gameResultListener { get { return (GameResultListenerComponent)GetComponent(GameStateComponentsLookup.GameResultListener); } }
    public bool hasGameResultListener { get { return HasComponent(GameStateComponentsLookup.GameResultListener); } }

    public void AddGameResultListener(System.Collections.Generic.List<IGameResultListener> newValue) {
        var index = GameStateComponentsLookup.GameResultListener;
        var component = CreateComponent<GameResultListenerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGameResultListener(System.Collections.Generic.List<IGameResultListener> newValue) {
        var index = GameStateComponentsLookup.GameResultListener;
        var component = CreateComponent<GameResultListenerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGameResultListener() {
        RemoveComponent(GameStateComponentsLookup.GameResultListener);
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

    static Entitas.IMatcher<GameStateEntity> _matcherGameResultListener;

    public static Entitas.IMatcher<GameStateEntity> GameResultListener {
        get {
            if (_matcherGameResultListener == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.GameResultListener);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherGameResultListener = matcher;
            }

            return _matcherGameResultListener;
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

    public void AddGameResultListener(IGameResultListener value) {
        var listeners = hasGameResultListener
            ? gameResultListener.value
            : new System.Collections.Generic.List<IGameResultListener>();
        listeners.Add(value);
        ReplaceGameResultListener(listeners);
    }

    public void RemoveGameResultListener(IGameResultListener value, bool removeComponentWhenEmpty = true) {
        var listeners = gameResultListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveGameResultListener();
        } else {
            ReplaceGameResultListener(listeners);
        }
    }
}
