using UnityEngine;

namespace SI
{
    public abstract class StateMachine : MonoBehaviour
    {        
        protected State State;

        public void SetState(State state)
        {
            State = state;
            State.StartState();
        }

    }
}