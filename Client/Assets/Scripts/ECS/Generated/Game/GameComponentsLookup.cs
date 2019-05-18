//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class GameComponentsLookup {

    public const int ActorId = 0;
    public const int Backup = 1;
    public const int Destroyed = 2;
    public const int Id = 3;
    public const int LocalId = 4;
    public const int Position = 5;
    public const int PositionListener = 6;

    public const int TotalComponents = 7;

    public static readonly string[] componentNames = {
        "ActorId",
        "Backup",
        "Destroyed",
        "Id",
        "LocalId",
        "Position",
        "PositionListener"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(Lockstep.Core.State.Game.ActorIdComponent),
        typeof(Lockstep.Core.State.Game.BackupComponent),
        typeof(Lockstep.Core.State.Game.DestroyedComponent),
        typeof(Lockstep.Core.State.Game.IdComponent),
        typeof(Lockstep.Core.State.Game.LocalIdComponent),
        typeof(Lockstep.Core.State.Game.PositionComponent),
        typeof(PositionListenerComponent)
    };
}
