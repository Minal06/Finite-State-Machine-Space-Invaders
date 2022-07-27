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
            GameSystem.Canvas.GoCanvas(true);
            GameSystem.Canvas.PauseScrn(true);
            GameSystem.Canvas.ExitButton(true);
        }
        public override void ExitState()
        {
            GameSystem.Canvas.GoCanvas(false);
            GameSystem.Canvas.PauseScrn(false);
            GameSystem.Canvas.ExitButton(false);
            Time.timeScale = 1;
            GameSystem.SetState(new GameState(GameSystem));
        }
    }
}