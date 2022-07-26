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
            GameSystem.Enemy.FasterEnemy();
            GameSystem.Enemy.EnemyAttack();

            GameSystem.Player.Movement();
            GameSystem.Player.Shot();
            GameSystem.Player.Bounds();
            GameWon();
            PauseGame();
        }

        public override void ExitState()
        {
            GameSystem.SetState(new LostState(GameSystem));
        }


        void GameWon()
        {
            if(GameSystem.Enemy.Holder.childCount == 1)
            {
                GameSystem.SetState(new WonState(GameSystem));
            }
        }

        void PauseGame()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                GameSystem.SetState(new PauseState(GameSystem));
            }
        }
                
    }    
}