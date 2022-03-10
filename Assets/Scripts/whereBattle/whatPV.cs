using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whatPV : MonoBehaviour
{
    // Start is called before the first frame update
    public static int a;

    public GameObject PVE;
    public GameObject PVP;

    void Start()
    {
        if (a == 1)
        {
            PVP.SetActive(true);
        }
        else
        {
            PVE.SetActive(true);
        }

        a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
