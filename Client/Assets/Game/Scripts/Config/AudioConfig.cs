using System;
using System.Collections.Generic;
using System.Reflection;
using DesperateDevs.Utils;
using Entitas;
using Lockstep.ECS.Game;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Lockstep.Game {
   
    [CreateAssetMenu]
    public partial class AudioConfig : UnityEngine.ScriptableObject {
        public AudioClip born; 
        public AudioClip died;
        public AudioClip hitTank;
        public AudioClip hitBrick;
        public AudioClip hitIron;
        public AudioClip destroyIron;
        public AudioClip destroyGrass;
        public AudioClip addItem;
        public AudioClip bgMusic;
        public AudioClip startMusic;
    }
}