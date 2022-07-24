using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SI
{
    public class BeginGame : State
    {
        public BeginGame(GameSystem gameSystem) : base(gameSystem)
        {

        }
        public override IEnumerator Start()
        {
            //Buttons visible with Start Exit functions
            // when player hit start -> go to next state Prepare
            return base.Start();
            GameSystem.SetState(new PrepareGame(GameSystem));
        }
    }
}