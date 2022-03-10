using UnityEngine;


public class ChinarRotateObject : MonoBehaviour
{
    public Transform obj;
    public float     speed = 10;

    private bool _mouseDown = false;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            _mouseDown = true;
        else if (Input.GetMouseButtonUp(0))
            _mouseDown = false;
        if (!_mouseDown) return;
        float fMouseX = Input.GetAxis("Mouse X");
        float fMouseY = Input.GetAxis("Mouse Y");
        obj.Rotate(Vector3.up, -fMouseX   * speed, Space.World);
        obj.Rotate(Vector3.right, fMouseY * speed, Space.World);
    }
}