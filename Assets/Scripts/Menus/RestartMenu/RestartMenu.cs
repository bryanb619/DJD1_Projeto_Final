using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    public void RestartButton ()
    {   
        SceneManager.LoadScene("Game");
    }
    public void QuitButton ()
    {   
        Application.Quit();
        // Para saber se funciona, remover este código em versão futura
        Debug.Log("Game was Quitted");
    }
}
