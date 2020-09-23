using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public static int score;
    public int scoretracker;
    
    public TextMeshProUGUI menuscoretext;
    public TextMeshProUGUI menuhighscoretext;


    // Update is called once per frame
    void Update()
    {
        scoretracker = score;
        if(BirdMovement.gameover == true)
        {
            PlayerPrefs.SetInt("score", score);
            if (score > PlayerPrefs.GetInt("highscore", 0))
            {
                PlayerPrefs.SetInt("highscore", score);
            }
            menuscoretext.text = "" + score;
            menuhighscoretext.text = "" + PlayerPrefs.GetInt("highscore", 0);
        }
    }

    public void Restart()
    {
        BirdMovement.gameover = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}