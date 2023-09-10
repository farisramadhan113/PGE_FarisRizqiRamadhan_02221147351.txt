using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Skoring : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    public string game1SceneName = "Game1";
    public string game2SceneName = "Game2";

    public void IncreaseScore(int points)
    {
        score += points;
        UpdateScoreText();

        if (score >= 100)
        {
            SceneManager.LoadScene(game2SceneName);
        }
    }
    
    public void UpdateIncreaseScore(int points)
    {
        score += points;
        UpdateScoreText();
        
        if (score == 200 )
        {
            SceneManager.LoadScene("Menang");
        }
    }

     

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
