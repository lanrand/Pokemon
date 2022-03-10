using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickTest1 : MonoBehaviour//, IPointerDownHandler
{
    public bool isClick = false;
    public GameObject theObject;

     void OnMouseDown()
    {
        if (isClick)
        {
            isClick = false;
            theObject.SetActive(true);
        }
        else
        {
            isClick = true;
            theObject.SetActive(false);
        }
    }


}
