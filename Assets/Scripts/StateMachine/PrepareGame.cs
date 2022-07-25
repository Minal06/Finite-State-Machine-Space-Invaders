using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SI
{
    public class PrepareGame : State
    {
        public PrepareGame(GameSystem gameSystem) : base(gameSystem) { }

        public override IEnumerator StartState()
        {
            Debug.Log("hello from PrepareGame state");
            //Start to spawn enemy, wrote msg with KeyInfo 
            yield return new WaitForSeconds(5f);
            GameSystem.SetState(new GameState(GameSystem));
        }
               
    }   
}