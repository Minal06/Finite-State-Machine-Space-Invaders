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

        public override IEnumerator StartState()
        {            
            GameSystem._canvas.SetActive(true);
            GameSystem.startButton.SetActive(true);
            GameSystem.exitButton.SetActive(true);
            //GameSystem.GoCanvas();
            yield break;
        }
        public override IEnumerator ExitState()
        {            
            GameSystem._canvas.SetActive(false);
            GameSystem.startButton.SetActive(false);            
            //GameSystem.GoCanvas();
            GameSystem.SetState(new PrepareGame(GameSystem));
            yield break;                     
        }
         
    }
}