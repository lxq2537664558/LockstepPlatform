﻿using Lockstep.Math;
using Entitas;
using Lockstep.Game;

namespace Lockstep.ECS.Game
{
    [Game]
    [System.Serializable]
    public class ItemTypeComponent : IComponent {
        public int Type;
    }
}