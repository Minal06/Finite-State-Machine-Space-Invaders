using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace SI {
    public class HealthController : MonoBehaviour
    {
        private float currentHealth;
        [SerializeField]private Material myMaterial;

        private void Start()
        {            
            GameEvent.current.OnDamageTaken += HealthUpdate;
            myMaterial.color = Color.white;

        }       
        private void HealthUpdate()
        {
            //updateHealthBar
            currentHealth = GameSystem.SharedInstance.Player.GetComponent<PlayerHealth>().Health;
            Debug.Log(currentHealth);
            switch (currentHealth)
            {
                case 5:                    
                    break;
                case 4:
                    myMaterial.color = Color.blue;
                    break;
                case 3:
                    myMaterial.color = Color.yellow;
                    break;
                case 2:
                    myMaterial.color = Color.red;
                    break;
                case 1:
                    myMaterial.color = Color.black;
                    break;                    
            }
                

        }
    }
}