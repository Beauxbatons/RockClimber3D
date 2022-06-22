using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject objToDestroy;
    public GameObject particle;
     void OnTriggerEnter(Collider other)
     {
        //If the player touches the enemy trigger, it is destroyed

        if (other.gameObject.tag == "Player")
             Instantiate(particle, transform.position, transform.rotation);

         StartCoroutine(wait());
         Destroy(objToDestroy);
       

        IEnumerator wait()
        {
         
            yield return new WaitForSecondsRealtime(1);

            //After a sec game over menu comes.
            GameOver.gameOver = true;

        }
     }    
}
