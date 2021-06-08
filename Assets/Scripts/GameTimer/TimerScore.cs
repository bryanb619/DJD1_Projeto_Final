using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimerScore : MonoBehaviour
{
    // Start Time is zero
    public float currentTime;
    // Timer is zero, so not active
    bool TimerActive = false;
    // 
    public Text TimerText;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;

        
    }

    // Update is called once per frame
    void Update()
    {
        if(TimerActive == true)
        {
            currentTime = currentTime + Time.deltaTime;

        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        // Time display
        TimerText.text = time.ToString(@"mm\:ss\:fff");        
    }
    public void StartTimer()
    {
        TimerActive = true;
    }

    public void StopTimer()
    {
        TimerActive = false;
    }
}
