using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace SI {
    public class PlayerHealth : MonoBehaviour, IDamageable<float>
    {
        [Header("Player Health")]
        [SerializeField] float health;     

                
        public float Health { get;private set; }               

        private void Start()
        {
            Health = health;   
            
        }

        public void Damage(float damageTaken)
        {
            Health -= damageTaken;               

            if (Health < 0)
                Health = 0;

            if(Health == 0)
            {
                GameSystem.SharedInstance.StartButton();
            }
        }                   
    }
}