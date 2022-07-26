using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySetup : MonoBehaviour
{
    [Header("Enemy Spawn Setup")]
    [SerializeField] Transform holder;
    [SerializeField] Transform enemyPref;
    [SerializeField] Transform topLeftEnemy;

    [Header("Enemy Spawn Options")]
    [SerializeField] int rows;
    [SerializeField] int columns;
    [SerializeField] float space;

    [Header("Enemy Speed and Reach and Fire")]
    [SerializeField] float eSpeed;
    [SerializeField] float eRange;
    [SerializeField] float eDrop;
    [SerializeField] float eFireRate;
    [SerializeField] float lastEnemySpeed;
    [SerializeField] float gameOverLine;
    private Vector3 eDirection = Vector3.right;    

   

    private void Update()
    {
        //EnemyMove();
        //FasterEnemy();
        //GameWin();
        //EnemyAttack();
    }

    public void EnemyPrepare()
    {
        Debug.Log("RESPIMY ENEMICH!!");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Vector3 startingPos = new Vector3(topLeftEnemy.position.x + col * space, topLeftEnemy.position.y, topLeftEnemy.position.z - row * space);
                Transform _enemy = Instantiate(enemyPref, startingPos, Quaternion.identity);
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

                holder.position += Vector3.back * eDrop;
                //Vector3 position = transform.position;
                //position.z -= eDrop;
                //transform.position = position;                

                return;
            }

            //if (enemy.position.z <= -gameOverLine)
            //{
            //    gameManager.PlayerIsDead();
            //    gameManager.GameOver();
            //}
        }
    }

    //void EnemyAttack()
    //{
    //    foreach (Transform enemy in holder)
    //    {
    //        if (!enemy.gameObject.activeInHierarchy)
    //        {
    //            continue;
    //        }
    //        if (Random.value < (eFireRate / holder.childCount))
    //        {
    //            GameObject pooledProjectile = ObjectPooler.SharedInstance.GetPooledBullet("EnemyBullet");
    //            if (pooledProjectile != null)
    //            {
    //                pooledProjectile.SetActive(true); // activate it
    //                pooledProjectile.transform.position = enemy.transform.position; //position at enemy
    //            }
    //        }

    //    }
    //}

    void FasterEnemy()
    {
        if (holder.childCount == 1)
        {
            transform.position += (eDirection * eSpeed * Time.deltaTime) * lastEnemySpeed;
        }
    }

    //void GameWin()
    //{
    //    if (holder.childCount == 0)
    //    {
    //        gameManager.GameOver();
    //    }
    //}
}
