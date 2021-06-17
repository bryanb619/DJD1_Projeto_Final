using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionHealth : MonoBehaviour
{
    // Damage on player
    int healthGain = 25;
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
            Debug.Log($"{name} Contact with Player");

            //  Find hearts script Gain Life void and appy health gain
            FindObjectOfType<Hearts>().GainLife(healthGain);

            //
            Destroy(gameObject);
        }
    }
}
