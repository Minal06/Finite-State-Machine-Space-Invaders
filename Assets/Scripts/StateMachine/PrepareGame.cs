using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SI
{
    public class PrepareGame : State
    {
        private float preparationTime = 5;        
        public PrepareGame(GameSystem gameSystem) : base(gameSystem) { }

        public override void StartState()
        {
            Debug.Log("PrepareGame state");
            GameSystem.Canvas.PreparationScrn(true);
            GameSystem.Canvas.timer.text = preparationTime.ToString("F0"); 
            GameSystem.Enemy.EnemyPrepare();                                     
        }

        public override void UpdateState()
        {
            Preparation();            
        }
        public override void ExitState()
        {
            GameSystem.Canvas.PreparationScrn(false);
        }


        void Preparation()
        {
            if (preparationTime > 0)
            {
                preparationTime -= Time.deltaTime;
                GameSystem.Canvas.timer.text = preparationTime.ToString("F0");
            }
            else
            {
                ExitState();
                GameSystem.SetState(new GameState(GameSystem));
            }           
        }       
               
    }   
}