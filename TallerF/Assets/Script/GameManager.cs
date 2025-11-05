using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score;
    public int falls;
    public float timeElapsed;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
    }

    public void AddScore(int value)
    {
        score += value;
    }

    public void AddFall()
    {
        falls++;
    }

    public void NextScene()
    {
        SceneManager.LoadScene("Escena2");
    }
}
