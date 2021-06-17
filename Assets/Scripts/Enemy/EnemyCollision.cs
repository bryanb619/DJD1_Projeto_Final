using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider2D))]

public class EnemyCollision : MonoBehaviour
{
    public Healthbar healthbar;

    public int currentHealth;

    public int Maxhealth = 100;

    // Damage on player
    int damage = 25;
    // Looks for 
    void StartTriggering()
    {
        InitTrigger();

        currentHealth = Maxhealth;
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
            FindObjectOfType<Hearts>().LoseLife(damage);
            currentHealth -= damage;
            healthbar.SetHealth(currentHealth);


        }
    }
}





