using UnityEngine;
namespace SI
{
    internal class LostState : State
    {
        public LostState(GameSystem gameSystem) : base(gameSystem)
        {
        }

        public override void StartState()
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
            GameSystem.Canvas.YouLost(true);
        }
    }
}