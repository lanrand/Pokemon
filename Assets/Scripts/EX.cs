using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EX : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public void Exit()
    {
        SceneManager.LoadScene("firstscene");
    }
}
