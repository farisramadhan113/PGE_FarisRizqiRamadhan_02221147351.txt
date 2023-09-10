using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string gameSceneName = "Game1";

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            // 
            SceneManager.LoadScene(gameSceneName);
        }
    }

    public void StartGame()
    {
        // Metode ini digunakan jika tombol "Start Game" diklik secara visual.
        SceneManager.LoadScene(gameSceneName);
    }
}
