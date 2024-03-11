using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 cameraOffset;

    private void Start()
    {
        transform.position = playerTransform.position + cameraOffset;
    }

    private void Update()
    {
        if (playerTransform)
            gameObject.transform.position = playerTransform.position + cameraOffset;
    }
}
