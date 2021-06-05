using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class EnemyCollision : MonoBehaviour
{
    
    void StartTriggering()
    {
        InitTrigger();
    }

    void InitTrigger()
    {
        //  Turns trigger on
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    // detection of collision (takes health, not now...)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log($"{name} Contact");
        }
    }
}


