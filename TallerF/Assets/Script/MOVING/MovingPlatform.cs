using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveDistance = 3f;   
    public float speed = 2f;        

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;  
    }

    void Update()
    {
        
        float newY = startPos.y + Mathf.Sin(Time.time * speed) * moveDistance;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}
