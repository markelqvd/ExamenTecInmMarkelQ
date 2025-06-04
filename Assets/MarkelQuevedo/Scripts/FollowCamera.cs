using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    private Transform cameraTransform;

    private void Start()
    {
        // Encuentra la c�mara principal (AR Camera)
        cameraTransform = Camera.main.transform;
    }

    private void Update()
    {
        // Sigue la posici�n de la c�mara
        transform.position = cameraTransform.position;
    }
}
