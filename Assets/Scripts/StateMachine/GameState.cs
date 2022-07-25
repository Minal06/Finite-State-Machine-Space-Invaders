using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SI
{
    public class GameState : State
    {
        public GameState(GameSystem gameSystem) : base(gameSystem) { }

        public override IEnumerator StartState()
        {
            Debug.Log("GameState now");
            yield break;
        }

    }    
}