using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State 
{
    protected GameSystem GameSystem;

    public State (GameSystem gameSystem)
    {
        GameSystem = gameSystem;
    }


    //przepisac state!!!!!!!!
    // ma zawieraæ np player/enemy/UI/Start
    public virtual IEnumerator Intro()
    {
        yield break;
    }

    public virtual IEnumerator Prepare()
    {
        yield break;
    }

    public virtual IEnumerator Game()
    {
        yield break;
    }

    public virtual IEnumerator Pause()
    {
        yield break;
    }

    public virtual IEnumerator End()
    {
        yield break;
    }
}
