using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent enemyMovement;
    public Transform player;
   
    void Start()
    {
        enemyMovement = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        enemyMovement.SetDestination(player.position);
        
    }
}
