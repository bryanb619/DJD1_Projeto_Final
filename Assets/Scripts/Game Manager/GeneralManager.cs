using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralManager : MonoBehaviour
{   
    
    // restart Scene will be loaded if player out of health
    public void Restart()
    {
        SceneManager.LoadScene("RestartMenu");

    }
    
}
