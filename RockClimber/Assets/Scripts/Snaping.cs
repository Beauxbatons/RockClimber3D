using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snaping : MonoBehaviour
{
    public GameObject a;
    public GameObject b;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a.transform.position = b.transform.position;

    }
}
