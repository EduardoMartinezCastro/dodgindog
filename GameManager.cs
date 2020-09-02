using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    bool gameOver = false;

    int score = 0;

    public Text scoreText;
    public GameObject gameOverPanel;
    private void Awake() {
        if(instance == null) {
            instance = this;
        }
    }

    public void incrementScore() {
        if(!gameOver) {
            score++;
            scoreText.text = score.ToString();
        }
    }

    public void mainMenu() {
        SceneManager.LoadScene("MainMenu");
    }

    public void restart() {
        SceneManager.LoadScene("Gameplay");
    }

    public void endGame() {
        gameOver = true;
        GameObject.Find("SawSpawner").GetComponent<ObstacleSpawner>().stopSpawning();
        gameOverPanel.SetActive(true);
    }
}
