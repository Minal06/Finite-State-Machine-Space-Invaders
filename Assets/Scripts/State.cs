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
    // ma zawiera np player/enemy/UI/Start
    public virtual IEnumerator Start()
    {
        yield break;
    }

    public virtual IEnumerator Player()
    {
        yield break;
    }

    public virtual IEnumerator Enemy()
    {
        yield break;
    }
      
}
