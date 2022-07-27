using System.Collections;
using UnityEditor;
using UnityEngine;
using System.IO;

namespace SI
{
    public class EnemySetup : MonoBehaviour
    {
        [Header("Enemy Spawn Setup")]
        [SerializeField] Transform holder;
        [SerializeField] Transform[] prefabs;       
        [SerializeField] Transform topLeftEnemy;
        
        [Header("Enemy Spawn Options")]
        [SerializeField] int rows;
        [SerializeField] int columns;
        [SerializeField] float space;

        [Header("Enemy Speed and Reach and Fire")]
        [SerializeField] float eSpeed;
        [SerializeField] float eRange;
        [SerializeField] float eFireRate;
        [SerializeField] int eDamage;
        [SerializeField] float lastEnemySpeed;        
        private Vector3 eDirection = Vector3.right;

        public Transform Holder => holder;

        [System.Serializable]
        public class EnemyData
        {            
            public float speed;
            public float fireRate;
            public int damage;
        }     
       
        private void Start()
        {
            LoadEnemyStats();
        }
        
        void LoadEnemyStats()
        {
            string path = Application.dataPath + "/EnemyData/EnemyData.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                EnemyData data = JsonUtility.FromJson<EnemyData>(json);

                eSpeed = data.speed;
                eFireRate = data.fireRate;
                eDamage = data.damage;
            }
            else
                Debug.Log("No File with Enemy Data");            
        }

        public void EnemyPrepare()
        {
            Debug.Log("RESPIMY ENEMICH!!");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Vector3 startingPos = new Vector3(topLeftEnemy.position.x + col * space, topLeftEnemy.position.y, topLeftEnemy.position.z - row * space);
                    Transform _enemy = Instantiate(prefabs[row], startingPos, Quaternion.identity);
                    _enemy.SetParent(holder);
                }
            }
        }

        public void EnemyMove()
        {
            transform.position += eDirection * eSpeed * Time.deltaTime;

            foreach (Transform enemy in holder)
            {
                if (!enemy.gameObject.activeInHierarchy)
                {
                    continue;
                }

                if (enemy.position.x <= -eRange || enemy.position.x >= eRange)
                {
                    eSpeed = -eSpeed;                                

                    return;
                }
                
            }
        }

        public void EnemyAttack()
        {
            foreach (Transform enemy in holder)
            {
                if (!enemy.gameObject.activeInHierarchy)
                {
                    continue;
                }
                if (Random.value < (eFireRate / holder.childCount))
                {
                    GameObject pooledProjectile = BulletPooler.SharedInstance.AllocatePooledBullet("EnemyBullet");
                    if (pooledProjectile != null)
                    {
                        pooledProjectile.SetActive(true); // activate it
                        pooledProjectile.transform.position = enemy.transform.position; //position at enemy
                    }
                }

            }
        }

        public void FasterEnemy()
        {
            if (holder.childCount == 2)
            {
                transform.position += (eDirection * eSpeed * Time.deltaTime) * lastEnemySpeed;
            }
        }
    }
}