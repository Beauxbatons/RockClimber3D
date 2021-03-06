using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSnap : MonoBehaviour
{
    //Character climbing by clicking on rocks
    private Streching _streching;

        private void Awake()
    {
        _streching = FindObjectOfType<Streching>();
    }

    private void OnMouseDown()
    {
        _streching.snapTarget = this.gameObject;
    }

    void DestroyScriptInstance()
    {

        Destroy(this);
    }
}
