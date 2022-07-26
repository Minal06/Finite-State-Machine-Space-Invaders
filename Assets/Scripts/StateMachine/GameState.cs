using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SI
{
    public class GameState : State
    {
        public GameState(GameSystem gameSystem) : base(gameSystem) { }

        public override void StartState()
        {
            Debug.Log("GameState now");
            
        }

        public override void UpdateState()
        {
            GameSystem.Enemy.EnemyMove();
        }
    }    
}