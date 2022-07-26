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

        
        public virtual void StartState()
        {
            
        }

        public virtual void UpdateState()
        {
            
        }

        public virtual void ExitState()
        {
            
        }

    }
}