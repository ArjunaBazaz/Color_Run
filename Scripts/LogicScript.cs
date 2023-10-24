using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int playerHealth;
    public Text scoreText;
    public Text healthText;
    public Text finalScoreText;
    public GameObject gameoverScreen;
    public GameObject p;
    public GameObject missed;
    public GameObject health;
    public GameObject spawner;
    public GameObject score;
    public AudioSource failSFX;
    public AudioSource dingSFX;

    void Start()
    {
        playerHealth = 10;
        playerScore = 0;
    }

    public void incrementScore()
    {
        dingSFX.Play();
        playerScore += 1;
        scoreText.text = playerScore.ToString();
        finalScoreText.text = playerScore.ToString();
    }

    /* public void incrementHealth()
    {
        playerHealth += 1;
        healthText.text = playerHealth.ToString();
    } */

    public void decrementHealth()
    {
        playerHealth -= 1;
        healthText.text = playerHealth.ToString();
        if(playerHealth <= 0)
        {
            failSFX.Play();
            Destroy(p);
            Destroy(missed);
            Destroy(health);
            Destroy(spawner);
            Destroy(score);
            gameOver();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameoverScreen.SetActive(true);
    }

    public void quit()
    {
        SceneManager.LoadScene("Start Screen");
    }

    public void toInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }
}
