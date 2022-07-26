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
            GameSystem.Enemy.EnemyPrepare();
            //Start to spawn enemy, wrote msg with KeyInfo 
            //wait for 5 sec
            
        }

        public override void UpdateState()
        {
            Preparation();            
        }


        void Preparation()
        {
            if (preparationTime > 0)
            {
                preparationTime -= Time.deltaTime;
            }
            else         
            GameSystem.SetState(new GameState(GameSystem));
        }       
               
    }   
}