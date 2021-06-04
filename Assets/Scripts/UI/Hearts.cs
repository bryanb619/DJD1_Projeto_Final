using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    public Image[] Lives;
    public int RemainingLives;



    public void LoseLife()
    {
        // remove lives with decrementation
        RemainingLives--;
        // Removal of heart Icon

        // if we have no lifes left
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
