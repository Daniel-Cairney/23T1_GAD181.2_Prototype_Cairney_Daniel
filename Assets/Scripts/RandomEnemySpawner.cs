using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;
    int randEnemy;
    public int enemiesSpawned = 0;
    public int enemiesMax;

   
    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
        if ((enemiesMax < enemiesSpawned))
        {
            stop = true;
        }
        else
        {
            stop = false;
        }
    }

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)

        {
            randEnemy = Random.Range(0, 3);
            Vector3 spawnPosition = new Vector3((Random.Range(-spawnValues.x, spawnValues.x)), 1, Random.Range(-spawnValues.x, spawnValues.x));

            Instantiate((enemies[randEnemy]), spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(spawnWait);
        }

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(transform.position, spawnValues);
    }

}



