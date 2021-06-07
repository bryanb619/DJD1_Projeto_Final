using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class EnemyCollision : MonoBehaviour
{   
    int HealthDecay = 20;
    // Looks for 
    void StartTriggering()
    {
        InitTrigger();
    }

    void InitTrigger()
    {
        //  Turns trigger on
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    // detection of collision ("DEBUG REQUIRED")
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {   
            Debug.Log($"{name} Contact with Player");
            FindObjectOfType<Hearts>().LoseLife(HealthDecay);
            
        }
    }
}


