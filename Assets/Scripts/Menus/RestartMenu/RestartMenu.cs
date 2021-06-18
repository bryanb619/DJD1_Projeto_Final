using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    // UI buttons

    // Restart button
    public void RestartButton ()
    {   Debug.Log("Game was Loaded");
        SceneManager.LoadScene("Game");
    }
    // menu button
    public void MainMenuButton()
    {   
        Debug.Log("Menu is loaded");
        SceneManager.LoadScene("StartMenu");
    }
    // quit button
    public void QuitButton ()
    {   
        Application.Quit();
        Debug.Log("Game was Quitted");
    }


}
