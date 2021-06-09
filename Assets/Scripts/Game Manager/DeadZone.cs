using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class DeathZone : MonoBehaviour
{   
    int HealthDecay = 100;
    // Looks for 
    void Start()
    {
        Trigger();
    }

    void Trigger()
    {
        //  Turns trigger on
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    //  detects collision  with player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {   
            Debug.Log($"{name} Contact with Player");
            FindObjectOfType<Hearts>().LoseLife(HealthDecay);
            
        }
    }
}
