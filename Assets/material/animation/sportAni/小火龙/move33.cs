using UnityEngine;
using System.Collections;

public class move33 : MonoBehaviour
{

    public float speed_move;

     
    private void Start()
    {
        Application.targetFrameRate = 60;

      
    }
    void FixedUpdate()
    {
        Physics.gravity = new Vector3(0, -35, 0);
        float y = Input.GetAxis("Horizontal")
                * Time.deltaTime * speed_move;
        float x = Input.GetAxis("Vertical")
                * Time.deltaTime * speed_move;
        transform.Translate(-x, 0, y);


        if (Input.GetKey(KeyCode.Q))

        {

            transform.Rotate(new Vector3(0,1,0), -1.2f);

        }

        if (Input.GetKey(KeyCode.E))

        {

            transform.Rotate(new Vector3(0,1,0), 1.2f);

        }
    }

}

