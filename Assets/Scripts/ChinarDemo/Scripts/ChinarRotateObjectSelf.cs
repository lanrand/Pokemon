using UnityEngine;
using System.Collections;


public class ChinarRotateObjectSelf : MonoBehaviour
{
    public Vector3 mousePos;


    IEnumerator OnMouseDown()
    {
        mousePos = Input.mousePosition;
        while (Input.GetMouseButton(0))
        {
            Vector3 offset = mousePos - Input.mousePosition;
            transform.Rotate(Vector3.up   * offset.x, Space.World);
            transform.Rotate(Vector3.left * offset.y, Space.World);
            mousePos = Input.mousePosition;
            yield return null;
        }
    }
}