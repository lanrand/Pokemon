using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscExit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("firstScene");
        }

/*        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Debug.Log("Space key was released.");
        }*/
    }
}
