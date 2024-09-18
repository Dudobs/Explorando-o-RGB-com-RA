using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform cameraTransform; // Referência à câmera que o cubo seguirá
    public Vector3 offset = new Vector3(0, 0, 2); // Posição relativa à câmera

    void Update()
    {
        // Mantém o cubo na frente da câmera
        transform.position = cameraTransform.position + cameraTransform.forward * offset.z;
        transform.LookAt(cameraTransform);  // Faz com que o cubo sempre olhe para a câmera
    }
}
