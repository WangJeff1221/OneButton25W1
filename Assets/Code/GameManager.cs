using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int avoidedObstacles = 0;
    public int winThreshold = 10;
    private int score = 0; 
    public TMP_Text scoreText; 

    void Awake()
    {
        instance = this;
    }

    public void GameOver()
    {
        Debug.Log("Game Over!");
        SceneManager.LoadScene("GameOverScene");
    }

    public void ObstaclePassed()
    {
        avoidedObstacles++;
        if (avoidedObstacles >= winThreshold)
        {
            WinGame();
        }
    }

    void WinGame()
    {
        Debug.Log("You Win!");
        SceneManager.LoadScene("WinScene");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void UpdateScore(int amount)
    {
        score += amount;
        if (scoreText != null)
        {
            scoreText.text = "Coin: " + score;
        }
        Debug.Log("Coin：" + score);
    }
}
