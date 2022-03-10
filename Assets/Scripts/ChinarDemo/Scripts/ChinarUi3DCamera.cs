using UnityEngine;

/// <summary>
/// 主相机脚本 —— 挂载到主相机上，并 层次列表中的 Plane 拖到 pivot 
/// </summary>
public class ChinarUi3DCamera : MonoBehaviour
{
    public Transform pivot;
    public Vector3 pivotOffset = Vector3.zero;
    public Transform target;
    public float distance = 10.0f;
    public float minDistance = 2f;
    public float maxDistance = 15f;
    public float zoomSpeed = 1f;
    public float xSpeed = 250.0f;
    public float ySpeed = 120.0f;
    public bool allowYTilt = true;
    public float yMinLimit = -90f;
    public float yMaxLimit = 90f;
    private float x = 0.0f;
    private float y = 0.0f;
    private float targetX = 0f;
    private float targetY = 0f;
    private float xVelocity = 1f;
    private float yVelocity = 1f;
    private float zoomVelocity = 1f;


    private void Start()
    {
        var angles = transform.eulerAngles;
        targetX = x = angles.x;
        targetY = y = ClampAngle(angles.y, yMinLimit, yMaxLimit);
    }


    private void LateUpdate()
    {
        if (!pivot) return;
        var scroll = Input.GetAxis("Mouse ScrollWheel");

        if (scroll > 0.0f) distance -= zoomSpeed;
        else if (scroll < 0.0f)
            distance += zoomSpeed;
        distance = Mathf.Clamp(distance, minDistance, maxDistance);
        if (Input.GetMouseButton(1) || (Input.GetMouseButton(0) && (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))))
        {
            targetX += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
            if (allowYTilt)
            {
                targetY -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
                targetY = ClampAngle(targetY, yMinLimit, yMaxLimit);
            }
        }
        x = Mathf.SmoothDampAngle(x, targetX, ref xVelocity, 0f);
        y = allowYTilt ? Mathf.SmoothDampAngle(y, targetY, ref yVelocity, 0f) : targetY;
        Quaternion rotation = Quaternion.Euler(y, x, 0);
        distance = Mathf.SmoothDamp(distance, distance, ref zoomVelocity, 0f);
        Vector3 position = rotation * new Vector3(0.0f, 0.0f, -distance) + pivot.position + pivotOffset;
        transform.rotation = rotation;
        transform.position = position;
    }


    private static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360) angle += 360;
        if (angle > 360) angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }
}