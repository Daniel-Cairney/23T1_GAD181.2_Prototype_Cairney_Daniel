using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
   float speed = 3f;
   float distance;

    private void FixedUpdate()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        distance = Vector3.Distance(transform.position, player.transform.position);
        Vector3 direcion = player.transform.position - transform.position;
        direcion.Normalize();
        float angle = Mathf.Atan2(direcion.y, direcion.x) * Mathf.Rad2Deg - 90f;

        transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
    }
}
