using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudTimer : MonoBehaviour
{   
    // Variables
    // Starting time = zero as normal stopwatch
    public float startTime;
    // UI Text in canvas (Game Scene)
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        // float to string conversion
        timerText.text = startTime.ToString("F2"); 

    }
    // Update is called once per frame
    // Time update per FPS
    void Update()
    {   
        // timer using delta dime to count every second
        startTime += Time.deltaTime;
        // conversion to string
        timerText.text = startTime.ToString("F2");
    }
}
