using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralManager : MonoBehaviour
{   
    
    // method de respawn
    public void Restart()
    {
        SceneManager.LoadScene("RestartMenu");

    }
    
}
