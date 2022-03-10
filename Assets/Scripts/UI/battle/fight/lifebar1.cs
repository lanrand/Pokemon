
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifebar1 : MonoBehaviour
{
    Image img;
    // Use this for initialization
    void Start()
    {
        img = GetComponent<Image>();    //获取Image组件
    }

    // Update is called once per frame
    void Update()
    {
        //血量减少
        if (Input.GetKey(KeyCode.A))
        {
            img.fillAmount -= 0.01f;
        }
        //血量增加
        if (Input.GetKey(KeyCode.D))
        {
            img.fillAmount += 0.01f;
        }
    }
}
