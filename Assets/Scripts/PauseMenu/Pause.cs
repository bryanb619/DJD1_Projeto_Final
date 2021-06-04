using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    [SerializeField] GameObject pausemenu;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {   
            if(GameIsPaused)
            {
                ResumeLevel();
            }
            else
            {
                PauseLevel();
            }
        }     
    }

    void ResumeLevel()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    void PauseLevel()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true; 

    }
}
