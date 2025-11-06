using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   
    public string sceneName = "Scene2";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Jugador alcanz� el trigger de cambio de escena");
            GameManager.instance.LoadScene(sceneName);
        }

        

    }
    
    public void LoaderScenes(string nameScene) 
    {
      SceneManager.LoadScene(nameScene);  
    }
    
}
