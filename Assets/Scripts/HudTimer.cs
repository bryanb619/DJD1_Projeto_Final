using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudTimer : MonoBehaviour
{
    public static TimerControl instance;

    public Text Timer;

    private TimeSpan Playing;

    private bool TimerCounting;

    private float elapsedTime;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        TimerCounting.text = "Time : 00:00.00";
        timerCouning = false;
    }

    // Update is called once per frame
    
    public void StartTime()
    {
        Playing = true;
        TimerControl.instance.StartTimer();
    }
}
