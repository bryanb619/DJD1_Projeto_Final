using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausedMenuScript : MonoBehaviour
{
    //Checar pelo estado do jogo (paused ou não "true ou false")
    [SerializeField] GameObject pausemenu;
    public static bool GameisPaused = false;
   // public GameObject pausemenu;

    // Update is called once per frame
    void Update()
    {   // reconhecimento da tecla "escape"
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }

        }
    }
    // também serve como butão, e no caso de "esc" ser carregado
    public void ResumeGame()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }
    // Pause method
    void PauseGame()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

    // butões do pause mennu
    public void MainMenu()
    {
        Debug.Log("Loading menu...");
    }

   public void EXIT()
    {
        Application.Quit();
        // Para saber se funciona, remover este código em versão futura
        Debug.Log("Game has exitted");
    }


}
