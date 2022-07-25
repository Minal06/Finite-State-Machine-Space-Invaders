using System.Collections;


namespace SI
{
    public abstract class State
    {
        protected GameSystem GameSystem;

        public State(GameSystem gameSystem)
        {
            GameSystem = gameSystem;
        }

        
        public virtual IEnumerator StartState()
        {
            yield break;
        }

        public virtual IEnumerator UpdateState()
        {
            yield break;
        }

        public virtual IEnumerator ExitState()
        {
            yield break;
        }

    }
}