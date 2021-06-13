using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{   
    // Access methods from any script 
    public static PlayerScore instance;
    // Restart Scene and End Screen text boxes
    public Text scoreText;
    // OBS: TALVEZ CRIAR OUTRA

    // Score start point int
    private int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Score text on Restart UI
        scoreText.text = "Your Score is: " + score.ToString() + " Points"; 
    }

    // Add points (score) method
    public void AddPoint()
    {
        // score value
        score += 1;
        // New score text
        scoreText.text = scoreText.ToString() + " Points";
        // saving score
        PlayerPrefs.SetInt("Your Score is:", score);
        
    }
}
