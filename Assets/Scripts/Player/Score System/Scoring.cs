using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{

    public int score = 0;
    private int hiScore = 0;
    
    public bool scoreIncreasing;

    public Text playerScore;
    public Text playerHiScore;


    void Start()
    {
        if (PlayerPrefs.GetInt("HighScore") != null)
        {
            hiScore = PlayerPrefs.GetInt("HighScore");
        }
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddScore(150);
            Debug.Log(score);
        }

        if (score > hiScore)
        {
            hiScore = score;
            PlayerPrefs.SetFloat("HighScore", hiScore);
        }

        playerScore.text = "Score:"  + ((int)score).ToString();
        playerHiScore.text = "High Score: " + ((int)hiScore).ToString();


    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    public void AddScore(int pointsToAdd)
    {
        score += pointsToAdd;
    }
}