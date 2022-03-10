using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class video : MonoBehaviour
{
    private RawImage rawImage;
    private VideoPlayer videoPlayer;
    public Button[] buttons;
    public Image[] background;
    public GameObject login;
    bool flag;
    // Start is called before the first frame update
    void Start()
    {
        rawImage = GetComponent<RawImage>();
        videoPlayer = GetComponent<VideoPlayer>();
        rawImage.enabled = true;
        videoPlayer.enabled = true;
        flag = false;
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].enabled = false;
            buttons[i].image.enabled = false;
            Text text = buttons[i].gameObject.GetComponentInChildren<Text>();
            text.enabled = false;
        }
        for(int i=0; i < background.Length; i++)
        {
            background[i].enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true && flag == false)
        {
            login.SetActive(true);
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].enabled = true;
                buttons[i].image.enabled = true;
                Text text = buttons[i].gameObject.GetComponentInChildren<Text>();
                text.enabled = true;
            }
            for (int i = 0; i < background.Length; i++)
            {
                background[i].enabled = true;
            }
            flag = true;
        }
    }
}
