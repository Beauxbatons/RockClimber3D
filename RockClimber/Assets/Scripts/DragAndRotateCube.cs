﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndRotateCube : MonoBehaviour
{
    public bool isActive = false;
    Color activeColor = new Color();
    private GameObject target;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Rock");
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            activeColor = Color.red;

            if (Input.touchCount == 1)
            {
                Touch screenTouch = Input.GetTouch(0);

                if (screenTouch.phase == TouchPhase.Moved)
                {
                    player.transform.position = target.transform.position;
                }

                if (screenTouch.phase == TouchPhase.Ended)
                {
                    isActive = false;
                }
            }
        }
        else
        {
            activeColor = Color.white;
        }

        GetComponent<MeshRenderer>().material.color = activeColor;
    }
}