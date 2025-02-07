using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool birdIsAlive = true;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if (birdIsAlive == true)
        {
            playerScore = playerScore + scoreToAdd;
            scoreText.text = playerScore.ToString();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        birdIsAlive = false;
    }

    public void exitGame()
    {
        Debug.Log("Game is exiting..."); 
        Application.Quit();
    }
}
