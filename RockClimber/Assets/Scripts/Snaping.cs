using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snaping : MonoBehaviour
{
    //  public GameObject a;
    //  public GameObject b;
    public KeyCode grabKey;
    private GameObject target;
    private GameObject player;
    private bool isSnaped;

    


    private void Start()
    {
      target = GameObject.FindWithTag("Rock");
      player = GameObject.FindWithTag("Player");
    }


    void Update()
    {
        if (Input.GetKey(grabKey))
        {
            player.transform.position = target.transform.position;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isSnaped = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isSnaped = false;
    }
}
