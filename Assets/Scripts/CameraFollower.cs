using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform skater;
    public float cameraSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate()
    {
        transform.position = skater.position + offset;
    }
}
