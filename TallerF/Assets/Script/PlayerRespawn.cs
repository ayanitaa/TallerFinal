using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Vector3 lastCheckpoint; // almacena el último punto seguro

    void Start()
    {
        // el primer checkpoint será la posición inicial del jugador
        lastCheckpoint = transform.position;
    }

    public void SetCheckpoint(Vector3 newCheckpoint)
    {
        // guarda la nueva posición del checkpoint
        lastCheckpoint = newCheckpoint;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Si toca el "DeathZone", reaparece en el último checkpoint
        if (other.CompareTag("DeathZone"))
        {
            transform.position = lastCheckpoint;
            GameManager.instance.AddFall(); // suma una caída al contador
            Debug.Log("Jugador reapareció en checkpoint: " + lastCheckpoint);
        }
    }
}
