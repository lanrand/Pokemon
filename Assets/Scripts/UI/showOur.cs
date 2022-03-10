using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showOur : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject panel;
    private void OnMouseDown()
    {
        panel = transform.Find("panel").gameObject;
        panel.SetActive(true);
    }
}
