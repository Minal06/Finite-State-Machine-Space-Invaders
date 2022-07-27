using UnityEngine;

namespace SI
{
    internal class WonState : State
    {
        public WonState(GameSystem gameSystem) : base(gameSystem)
        {
        }

        public override void StartState()
        {
            Debug.Log("Congratz you Won");
            Time.timeScale = 0;
            GameSystem.Canvas.YouWon(true);
        }
    }
}