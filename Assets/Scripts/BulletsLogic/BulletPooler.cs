using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SI
{
    public class BulletPooler : MonoBehaviour
    {
        [System.Serializable]
        public class poolClass
        {
            public string bulletTag;
            public GameObject bulletToPool;
            public int bulletAmountToPool;
        }

        public List<poolClass> bulletPool;
        public Dictionary<string, Queue<GameObject>> pooledBullets;

        #region Singleton
        public static BulletPooler SharedInstance { get; private set; }

        private void Awake()
        {
            if (SharedInstance != null)
            {
                Destroy(gameObject);
                return;
            }
            SharedInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        #endregion

        private void Start()
        {
            pooledBullets = new Dictionary<string, Queue<GameObject>>();

            foreach (poolClass pool in bulletPool)
            {
                Queue<GameObject> poolQueue = new Queue<GameObject>();

                for (int i = 0; i < pool.bulletAmountToPool; i++)
                {
                    GameObject obj = Instantiate(pool.bulletToPool);
                    obj.SetActive(false);
                    poolQueue.Enqueue(obj);
                    obj.transform.SetParent(this.transform);
                }
                pooledBullets.Add(pool.bulletTag, poolQueue);
            }
        }

        public GameObject AllocatePooledBullet(string tag)
        {
            if (!pooledBullets.ContainsKey(tag))
            {
                Debug.LogWarning("Tag is not correct");
                return null;
            }

            GameObject bulletToSpawn = pooledBullets[tag].Dequeue();
            bulletToSpawn.SetActive(true);

            pooledBullets[tag].Enqueue(bulletToSpawn);

            return bulletToSpawn;
        }
    }
}