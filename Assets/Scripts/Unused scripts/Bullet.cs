using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    

    private void Start()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

        if (collision.gameObject.TryGetComponent<EnemyHP>(out EnemyHP enemyComponent))
        {
            enemyComponent.TakeDamage(1);
            Debug.Log("HIT");
           
        }
    }

}
