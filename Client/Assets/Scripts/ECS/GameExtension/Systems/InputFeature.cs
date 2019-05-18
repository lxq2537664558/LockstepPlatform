﻿using Lockstep.Game.Features.Input;

namespace Lockstep.Game.Features
{
    sealed class InputFeature : Feature
    {
        public InputFeature(Contexts contexts, IServiceContainer services) : base("Input")
        {
            //TODO: Add InputValidationSystem  
            Add(new ExecuteSpawnInput(contexts, services));

            //Performance-hit, only use for serious debugging
            //Add(new VerifySelectionIdExists(contexts));

            Add(new ExecuteMoveInput(contexts, services));
            //TODO: Add CleanupInput that removes input of validated frames (no rollback required => can be removed)
        }
    }
}
