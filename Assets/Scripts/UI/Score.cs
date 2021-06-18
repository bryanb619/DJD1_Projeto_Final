using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    // variables

    // Text on UI
    public Text ScoreText;
    // starting and current score
    private float score;

    void Start()
    {
        //
        score = 0;

        //
        ScoreText.text = "Your Score is! " + score;
    }

    void Update()
    {
        // 
        ScoreText.text = "Your Score is! " + score;
       
    }

    public void Points(int points)
    {
        score += points;

        //
        Update();
    }

}
