using System;
using System.IO;
using UnityEngine;

namespace Login
{
    public class createTxt : MonoBehaviour
    {
        void Start()
        {
            string fileName = Application.dataPath + "/Scripts/Login/namePsw.txt" ;
            Debug.Log(fileName);
            FileStream streamWriter = new FileStream(fileName,FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(streamWriter);
            sw.Close();
        }
    }
}