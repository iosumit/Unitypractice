using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource audioSource;
    bool isAudioPlayed = false;

    [ContextMenu("Increase Score")]
    public void addScore(int score)
    {
        playerScore = playerScore + score;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        if (!isAudioPlayed)
        {
            audioSource.Play();
            isAudioPlayed = false;
        }
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
