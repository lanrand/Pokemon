using System;
using System.Collections;
using UnityEngine;

namespace Scripts
{
    public class Log : MonoBehaviour
    {
        private float timer = 0;
        private void Start()
        {
            StartCoroutine("Wait");
            Time.timeScale = 0;
        }

        IEnumerator Wait()
        {
            while (timer<30)
            {
                yield return new WaitForSeconds(1);
                timer++;
                
            }
        }
    }
}