using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemySpawner : MonoBehaviour
{
    public GameObject[] myEnemies;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) ;
        {
            int randomIndex = Random.Range(0, myEnemies.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));

            Instantiate(myEnemies[randomIndex], randomSpawnPosition, Quaternion.identity);
        }
    }
}
