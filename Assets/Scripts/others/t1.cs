using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t1 : MonoBehaviour
{
    public bool WindowShow = false;
 

    void OnGUI()
    {
        GUIStyle labelFont = new GUIStyle();
        labelFont.fontSize = 20;
        if (WindowShow)
            GUI.Window(0, new Rect(80, 80, 250, 140), MyWindow, "新手提示");
    }
    //对话框函数;
    void MyWindow(int WindowID)
    {
        GUILayout.Label("欢迎来到Sustech-pokemon！" + "\n" +
            "请按wasdqe键进行移动，这里是熟悉的一教。"+"\n"+
            "请尽情探索世界吧");
    
    }
    //鼠标点击事件;
    void OnMouseDown()
    {
        Debug.Log("show");
        if (WindowShow)
            WindowShow = false;
        else
            WindowShow = true;
    }
}
