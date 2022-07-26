using UnityEngine;

namespace SI
{
    internal class PauseState : State
    {
        public PauseState(GameSystem gameSystem) : base(gameSystem)
        {
        }

        public override void StartState()
        {
            Time.timeScale = 0;
            GameSystem.Canvas.GoCanvas();
            GameSystem.Canvas.PauseScrn();
        }
        public override void ExitState()
        {
            GameSystem.Canvas.GoCanvas();
            GameSystem.Canvas.PauseScrn();
            Time.timeScale = 1;
            GameSystem.SetState(new GameState(GameSystem));
        }
    }
}