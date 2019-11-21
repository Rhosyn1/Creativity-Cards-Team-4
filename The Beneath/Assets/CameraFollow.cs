using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public float SmoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate()
    {
        transform.position = Target.position + offset;
    }


}
