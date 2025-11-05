using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    [Header("Configuración de rotación")]
    public Vector3 rotationAxis = new Vector3(0, 1, 0); 
    public float rotationSpeed = 45f; 

    void Update()
    {
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}
