using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionPoison : MonoBehaviour
{
    // Damage on player
    int damage = 10;
    // Looks for trigger
    void StartTriggering()
    {
        InitTrigger();
    }

    void InitTrigger()
    {
        //  Turns trigger on
        GetComponent<CapsuleCollider2D>().isTrigger = true;
    }

    // detection of collision ("DEBUG REQUIRED")
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            Debug.Log($"{name} Poisoned Player");

            // find hearts.cs loselife void (mudar aqui)
            FindObjectOfType<Hearts>().LoseLife(damage);

            // destroy potion 
            Destroy(gameObject);

        }
    }
}
