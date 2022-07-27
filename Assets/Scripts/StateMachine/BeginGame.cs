using System;
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

        public override void StartState()
        {              
            //True            
            GameSystem.Canvas.GoCanvas(true);
            GameSystem.Canvas.StartScrn(true);
            GameSystem.Canvas.ExitButton(true);
        }
        public override void ExitState()
        {            
            //False            
            GameSystem.Canvas.GoCanvas(false);
            GameSystem.Canvas.StartScrn(false);
            GameSystem.Canvas.ExitButton(false);
            GameSystem.SetState(new PrepareGame(GameSystem));
        }

    }
}