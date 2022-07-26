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
            //GameSystem._canvas.SetActive(true);            
            GameSystem.Canvas.GoCanvas();
            GameSystem.Canvas.StartScrn();
        }
        public override void ExitState()
        {            
            //GameSystem._canvas.SetActive(false);            
            GameSystem.Canvas.GoCanvas();
            GameSystem.Canvas.StartScrn();
            GameSystem.SetState(new PrepareGame(GameSystem));
        }

    }
}