using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    public Transform target;
    public float distanceFromTarget = 1.5f;
    public float speed = 20f;

    private void Start() { }

    private void Update()
    {
        transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
        Vector3 cameraPosition = target.position - transform.forward * distanceFromTarget;
        cameraPosition.y = transform.position.y;
        transform.position = cameraPosition;
    }
}
