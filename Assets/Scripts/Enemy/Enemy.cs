using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SI
{
    public class Enemy : MonoBehaviour, IKillable
    {        
        [SerializeField] private int pointsForThisEnemy;
        [SerializeField] private int enemyAttack;
                
        public int scoreValue => pointsForThisEnemy;      
        public int enemyAttackValue => enemyAttack;

        public void Kill()
        {
            Destroy(gameObject);
        }
    }
}