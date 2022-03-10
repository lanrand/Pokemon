using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class ButtonTest : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Button _button;

    private GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text = this.transform.Find("text").gameObject;
        text.GetComponent<Text>().text = "!!!!!!!!!!?????????";
        _button = this.GetComponent<Button>();
    }

    // Update is called once per frame

    public void OnPointerEnter(PointerEventData eventData)
    {
       text.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.SetActive(false);
    }
}
