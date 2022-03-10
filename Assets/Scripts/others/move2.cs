using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    public GameObject sphere;
    public Rigidbody sphereRigdbody;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            sphereRigdbody.AddForce(Vector3.forward * 15f * Time.deltaTime, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            sphereRigdbody.AddForce(Vector3.back * 15f * Time.deltaTime, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            sphereRigdbody.AddForce(Vector3.left * 15f * Time.deltaTime, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.D))
        {
            sphereRigdbody.AddForce(Vector3.right * 15f * Time.deltaTime, ForceMode.Impulse);
        }
    }
}
