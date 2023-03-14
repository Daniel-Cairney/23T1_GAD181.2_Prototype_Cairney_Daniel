using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{

    [SerializeField] private GameObject zombiePrefab;

    [SerializeField] private float zombieInterval = 3.5f;

    private int currentZombies;
    private int maxZombies = 20;
    
  
    void Start()
    {
        StartCoroutine(spawnEnemy(zombieInterval, zombiePrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        if(currentZombies > maxZombies){
           
        }
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy);
        enemy.transform.position = new Vector3(Random.Range(-10, 19), 0, Random.Range(27, 0)); //Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));


    }


}
