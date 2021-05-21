using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private float health = 0f;
    [SerializeField] 
    private float maxHealth = 100f;
    [SerializeField]
    private Slider healthbar;

    private void start()
    {
        health = maxHealth;
        healthbar.maxValue = maxHealth;

    }

    public void UpdateHealth(float mod)
    {
        health += mod;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
        else if (health <= 0)
        {
            health = 0f;
            Debug.Log("Death");
        }
    }

    private void OnGUI()
    {
        healthbar.value = health;
    }
}
