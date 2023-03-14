using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int counter;
    public GameObject[] enemies;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, 1f);
    }

    public void spawnEnemy()
    {
        if (--counter == 0) CancelInvoke("spawnEnemy");
        Instantiate(enemies[Random.Range(0, enemies.Length)], new Vector3(Random.Range(0, 5), Random.Range(0, 5), 0f), Quaternion.identity);  
    }
    

}
