using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SI
{
    public class PlayerController : MonoBehaviour
    {
        private float horizontalInput;
        [Header("Player Setup")]
        [SerializeField] float speed = 20.0f;
        [SerializeField] float horizontalRange = 20;
        [SerializeField] float reloadTime;              
        private bool isReloading = false;
                      

        private void Awake()
        {

        }

        // Update is called once per frame
        void Update()
        {            

        }

        public void Movement()
        {
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        }

        public void Shot()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (!isReloading) 
                {
                    GameObject pooledProjectile = BulletPooler.SharedInstance.AllocatePooledBullet("PlayerBullet");
                    if (pooledProjectile != null)
                    {
                        pooledProjectile.SetActive(true); // activate it
                        pooledProjectile.transform.position = transform.position; // position it at player
                    }
                    Invoke("Reload", reloadTime);
                    isReloading = true;
                }
                
            }
        }

        public void Bounds()
        {
            if (transform.position.x < -horizontalRange)
            {
                transform.position = new Vector3(-horizontalRange, transform.position.y, transform.position.z);
            }

            if (transform.position.x > horizontalRange)
            {
                transform.position = new Vector3(horizontalRange, transform.position.y, transform.position.z);
            }
        }

        private void Reload()
        {
            isReloading = false;
        }             
    }
}