using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public GameObject objectToDisable;
    public static bool disabled = false;
    void Start()
    {
        
    }


    void Update()
    {
        if (disabled)
            objectToDisable.SetActive(false);
        else
            objectToDisable.SetActive(true);
    }
}
