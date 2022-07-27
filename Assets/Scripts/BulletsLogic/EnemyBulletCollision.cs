using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SI
{
    public class EnemyBulletCollision : MonoBehaviour, IKillable
    {
        public int attackValue;

        private void OnTriggerEnter(Collider other)        {          

            switch (other.gameObject.tag)
            {         
                
                case "Player":                    
                    var damageable = other.gameObject.GetComponent<PlayerHealth>();
                    if (damageable == null) return;                    
                    damageable.Damage(attackValue);
                    GameEvent.current.DamageTaken();
                    Kill();
                    break;
                case "PlayerBullet":
                    var killable = other.gameObject.GetComponent<IKillable>();
                    if (killable == null) return;
                    Kill();
                    killable.Kill();
                    break; 
                case null:
                    break;
            }
        }
        public void Kill()
        {
            gameObject.SetActive(false);
        }
    }
}