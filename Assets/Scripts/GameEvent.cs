using System;
using UnityEngine;

namespace SI
{
    public class GameEvent : MonoBehaviour
    {
        public static GameEvent current;

        private void Awake()
        {
            current = this;
        }

        public event Action OnDamageTaken;

        public void DamageTaken()
        {
            if (OnDamageTaken != null)
            {
                OnDamageTaken();
            }
        }
    }
}