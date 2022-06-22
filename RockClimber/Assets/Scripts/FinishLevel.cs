using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    //If the player reaches the trigger at the finish, it go to the number two scene in the build settings.

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
}
