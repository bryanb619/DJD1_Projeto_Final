using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // Require edge collider
[RequireComponent(typeof(EdgeCollider2D))]

public class HealthReducer : MonoBehaviour
{   // Damage on player
    int damage = 25;
    //
    int lol = 0;
    float damageTime = 1.0f;

        
    // Looks for 
    void StartTriggering()
    {
        InitTrigger();
    }

    void InitTrigger()
    {
    //  Turns trigger on
    GetComponent<EdgeCollider2D>().isTrigger = true;
    }

    // detection of collision 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if collision = Player
        if (collision.tag == "Player")
        { 

            Debug.Log($"{name} Contact with Player");
            // find void Decreaser in hearts.cs
            FindObjectOfType<Hearts>().Decreaser(damageTime);
            // destroy edge collider zone
            Destroy(gameObject);

        }

    }

}
