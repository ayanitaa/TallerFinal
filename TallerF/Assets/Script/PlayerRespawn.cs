using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Vector3 lastCheckpoint; 
    void Start()
    {
       
        lastCheckpoint = transform.position;
    }

    public void SetCheckpoint(Vector3 newCheckpoint)
    {
        
        lastCheckpoint = newCheckpoint;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("DeathZone"))
        {
            transform.position = lastCheckpoint;
            GameManager.instance.AddFall(); 
            Debug.Log("Jugador reapareció en checkpoint: " + lastCheckpoint);
        }
    }
}
