using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class DeadZone : MonoBehaviour
{   
    private int HealthDecay = 100;
    // Looks for 
    void StartTriggering()
    {   
        // calls trigger
        TriggerPlayer();
    }
    // Trigger on Method
    void TriggerPlayer()
    {
        //  Turns trigger on
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    //  detects collision  with player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {   
            // Debug
            Debug.Log($"{name} Death zone Killed Player");
            // Use Hearts.cs, method LoseLife to apply damage
            FindObjectOfType<Hearts>().LoseLife(HealthDecay);
            
        }
    }
}
