using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject objToDestroy;
    public GameObject particle;
     void OnTriggerEnter(Collider other)
      {
         if (other.gameObject.tag == "Player")
             Instantiate(particle);

         // Destroy(objToDestroy);

         GameOver.gameOver = true;

       
    } 
      
   
}
