using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    public Image[] Lives;
    public int RemainingLives;

    public void LifeLost()
    {
        // remove lives with decrementation
        RemainingLives--;
        // Removal of heart Icon
        Lives[RemainingLives].enabled = false;
        // if we have no lifes left
        if (RemainingLives == 0)
        {
            Debug.Log("No lives left");
        }

        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                LifeLost();
            }
        }
    }
}
