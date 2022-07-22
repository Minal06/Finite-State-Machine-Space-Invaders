using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepareGame : State
{   
        public PrepareGame(GameSystem gameSystem) : base(gameSystem) { }   

    public override IEnumerator Intro()
    {
        //Start to spawn enemy, wrote msg with KeyInfo
        yield break;
    }
}
