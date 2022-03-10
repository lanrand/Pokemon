using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonClick : MonoBehaviour
{
    private Button button;
    Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        canvas = button.gameObject.GetComponentInParent<Canvas>();
        canvas.enabled = true;
    }

    public void startButton()
    {
        canvas.enabled = false;
    }

    public void loadGameButton()
    {
        //TODO load game
    }

    // Update is called once per frame

}
