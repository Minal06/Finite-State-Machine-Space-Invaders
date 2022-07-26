using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SI
{
    public class PlayerBulletCollisions : MonoBehaviour, IKillable
    {
        private void OnTriggerEnter(Collider other)
        {
            var killable = other.gameObject.GetComponent<IKillable>();
            if (killable == null) return;

            switch (other.gameObject.tag)
            {
                case "Base":
                    Kill();
                    break;

                case "Enemy":

                    killable.Kill();
                    Kill();
                    break;

                case "EnemyBullet":
                    killable.Kill();
                    Kill();
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