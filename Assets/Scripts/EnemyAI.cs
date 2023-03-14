using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent enemyMovement;
    public Transform Player;
    [SerializeField] private float moveSpeed = 1;


    void Start()
    {
        enemyMovement = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        //enemyMovement.destination = player.position;
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, moveSpeed * Time.deltaTime);
    }
}
