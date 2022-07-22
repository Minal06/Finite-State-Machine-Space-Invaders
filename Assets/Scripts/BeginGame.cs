using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginGame : State
{
    public BeginGame(GameSystem gameSystem) : base(gameSystem)
    {

    }
    public override IEnumerator Intro()
    {
        //Buttons visible with Start Exit functions
        // when player hit start -> go to next state Prepare
        return base.Intro();
        GameSystem.SetState(new PrepareGame(GameSystem));
    }
}
