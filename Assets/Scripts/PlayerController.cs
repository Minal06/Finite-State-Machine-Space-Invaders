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
        [SerializeField] float xRange = 20;
        [SerializeField] GameObject health1, health2, health3;
        //static nie powinien sie tu znajdowaæ
        //public static int pHealth = 3;


        //[SerializeField] GameManager gameManager;

        private void Awake()
        {

        }


        // Update is called once per frame
        void Update()
        {
            //// Check for left and right bounds
            //Bounds();

            //// Player movement left to right
            //Movement();

            ////shooting
            //Shot();

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
                GameObject pooledProjectile = BulletPooler.SharedInstance.AllocatePooledBullet("PlayerBullet");
                if (pooledProjectile != null)
                {
                    pooledProjectile.SetActive(true); // activate it
                    pooledProjectile.transform.position = transform.position; // position it at player
                }
            }
        }

        public void Bounds()
        {
            if (transform.position.x < -xRange)
            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }

            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }
        }

        //void IsPlayerKilled()
        //{
        //    switch (pHealth)
        //    {
        //        case 3:
        //            health1.gameObject.SetActive(true);
        //            health2.gameObject.SetActive(true);
        //            health3.gameObject.SetActive(true);
        //            break;
        //        case 2:
        //            health1.gameObject.SetActive(true);
        //            health2.gameObject.SetActive(true);
        //            health3.gameObject.SetActive(false);
        //            break;
        //        case 1:
        //            health1.gameObject.SetActive(true);
        //            health2.gameObject.SetActive(false);
        //            health3.gameObject.SetActive(false);
        //            break;

        //        case 0:
        //            health1.gameObject.SetActive(false);
        //            health2.gameObject.SetActive(false);
        //            health3.gameObject.SetActive(false);
        //            Destroy(gameObject);
        //            gameManager.PlayerIsDead();
        //            gameManager.GameOver();
        //            break;
        //    }
        //}
    }
}