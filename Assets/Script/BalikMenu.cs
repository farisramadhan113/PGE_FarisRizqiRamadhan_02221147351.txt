using UnityEngine;
using UnityEngine.SceneManagement;

public class BalikMenu : MonoBehaviour
{
    public string mainMenuSceneName = "Main";
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            // Jika tombol "Enter" ditekan, kembali ke menu utama.
            SceneManager.LoadScene(mainMenuSceneName);
        }
    }

    public void ReturnToMainMenu()
    {
        // Metode ini digunakan jika tombol visual di scene "Game Over" atau "Menang" diklik.
        SceneManager.LoadScene(mainMenuSceneName);
    }
}
