using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Cuando el jugador entra en el área del checkpoint
        if (other.CompareTag("Player"))
        {
            // Busca el script "PlayerRespawn" en el jugador
            other.GetComponent<PlayerRespawn>().SetCheckpoint(transform.position);
            Debug.Log("Checkpoint activado en: " + transform.position);
        }
    }
}
