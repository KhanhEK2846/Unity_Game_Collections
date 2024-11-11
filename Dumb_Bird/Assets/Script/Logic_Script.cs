using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logic_Script : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScene;

    public void addScore(){
        score += 1;
        scoreText.text = score.ToString();
    }

    public void restartGame(){
        Time.timeScale = 1; // No Pause
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void overGame(){
        gameOverScene.SetActive(true);
        Time.timeScale = 0;//Pause

    }

    public void ExitHome(){
        SceneManager.LoadScene(0);
    }

    public void Play(){
        Time.timeScale = 1; // No Pause
        SceneManager.LoadScene(1);

    }

    public void Exit(){
        Application.Quit();
    }
}
