using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    // variables
    // Health bar image
    public Image Lives;
    // player health
    private int PlayerHealth = 100;
    private int Maxhealth;
    // loss of health method
    public void LoseLife(int value)
    {
        if (PlayerHealth <= 0)
        {
            return;
        }
        PlayerHealth -= value;
        Lives.fillAmount = PlayerHealth / 100;
        // kill player
        if (PlayerHealth <= 0)
        {
            Debug.Log("Health is at 0%");
            // find player death in Player.cs
            FindObjectOfType<Player>().PlayerDeath();
        }
    }

    // add life method
    public void GainLife(int value)
    {
        // if heatlh is less than max health appply more life
        if (PlayerHealth < Maxhealth)
        {
            // player health + value (health gain,from potionHealth.cs)
            PlayerHealth += value;

            // Fill amount
            Lives.fillAmount = PlayerHealth / 100;
        }
    }

    public void Decreaser(float value)
    {



    }
}