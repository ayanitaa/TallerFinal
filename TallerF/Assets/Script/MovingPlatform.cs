using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveDistance = 3f;   // Qué tan alto/bajo se mueve
    public float speed = 2f;          // Velocidad del movimiento

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;  // Guarda la posición inicial
    }

    void Update()
    {
        // Movimiento vertical usando seno (sube y baja suavemente)
        float newY = startPos.y + Mathf.Sin(Time.time * speed) * moveDistance;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}
