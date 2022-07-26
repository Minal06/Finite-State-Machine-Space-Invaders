using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SI
{
    public class Enemy : MonoBehaviour, IKillable
    {
        public int scoreValue { get; private set; }
        [SerializeField] int pointsForThisEnemy;
        // Start is called before the first frame update
        void Start()
        {
            scoreValue = pointsForThisEnemy;
        }       

        public void Kill()
        {
            Destroy(gameObject);
        }
    }
}