﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    private bool hold;
    public KeyCode grabKey;
    public bool canGrab;
    public Animator animator;
    public bool RightHand;

    void Update()
    {
        if (canGrab)
        {
            if (Input.GetKey(grabKey))
            {
                if (RightHand)
                {
                    animator.SetBool("RightHand", true);
                }
                else
                {
                    animator.SetBool("LeftHand", true);
                }
                hold = true;
            }
            else
            {
                if (RightHand)
                {
                    animator.SetBool("RightHand", false);
                }
                else
                {
                    animator.SetBool("LeftHand", false);
                }

                hold = false;
                Destroy(GetComponent<FixedJoint>());
            }
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (hold && col.transform.tag != "Player")
        {
            Rigidbody rb = col.transform.GetComponent<Rigidbody>();
            if (rb != null)
            {
                FixedJoint fj = transform.gameObject.AddComponent(typeof(FixedJoint)) as FixedJoint;
                fj.connectedBody = rb;
            }
            else
            {
                FixedJoint fj = transform.gameObject.AddComponent(typeof(FixedJoint)) as FixedJoint;
            }
        }
    }
}   