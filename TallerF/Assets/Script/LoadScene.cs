using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   
    public string sceneName = "Scene2";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Jugador alcanzó el trigger de cambio de escena");
            GameManager.instance.LoadScene(sceneName);
        }
    }
}
