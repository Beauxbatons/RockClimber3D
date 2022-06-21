using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticSpike : MonoBehaviour
{
    private GameObject enemy;
    private GameObject character;
 
    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy");
        character = GameObject.FindWithTag("Character");
    }

 
    void Update()
    {
        
    }

   /* void OnTriggerEnter(Collider other)
    {
    
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(GetComponent<Snaping>());
        }
    }
    */

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Character"))
        {
            // gameObject.GetComponent<Collider>().enabled = false;
            Destroy(GetComponent<Snaping>());
        }
    }*/
}
