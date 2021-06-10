using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    public void RestartButton ()
    {   Debug.Log("Game was Loaded");
        SceneManager.LoadScene("Game");
    }
    public void MainMenuButton()
    {   
        Debug.Log("Menu is loaded");
        SceneManager.LoadScene("StartMenu");
    }
    public void QuitButton ()
    {   
        Application.Quit();
        // Para saber se funciona, remover este código em versão futura
        Debug.Log("Game was Quitted");
    }
}
