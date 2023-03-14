using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemykilldetection : MonoBehaviour
{
     MoneyCounter MoneyCounterScript;
    // Start is called before the first frame update
    void Start()
    {
        MoneyCounterScript = GameObject.Find("MCO").GetComponent<MoneyCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            MoneyCounterScript.AddMoney();
        }
    }
}
