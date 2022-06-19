using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snaping : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public KeyCode grabKey;
    private GameObject target;
    private GameObject player;



    private void Start()
    {
      target = GameObject.FindWithTag("Rock");
     target = GameObject.FindWithTag("Player");
    }


    void Update()
    {
       
    //  if (Input.GetKey(grabKey))
        {
     // a.transform.position = b.transform.position;


        //  GameObject.FindWithTag("Player").transform.position = GameObject.FindWithTag("Rock").transform.position;
        }
        

    }

    void OnCollisionEnter(Collision collision)
    {
        if (Input.GetKey(grabKey))
        {
            GameObject.FindWithTag("Player").transform.position = GameObject.FindWithTag("Rock").transform.position;


        }
    }

}
