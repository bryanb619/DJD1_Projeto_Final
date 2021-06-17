using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    // variables

    // Health bar image on UI
    public Image Lives;
    // player health
    private int PlayerHealth = 100;
    // player max healt
    private int Maxhealth = 100;
    // 
    public int currentHealth;
    //
    public float CurrentDamageTime;
    //
    public Healthbar healthbar;

    public int damage;

    void Start()
    {
        currentHealth = Maxhealth;
        healthbar.SetMaxHealth(Maxhealth);
    }
    // loss of health method
    public void LoseLife(int value)
    {
        if (PlayerHealth <= 0)
        {
            return;
        }
        
        PlayerHealth -= value;
        Lives.fillAmount = PlayerHealth / 100;

        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);

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
        if (PlayerHealth <= Maxhealth)
        {
            return;
        }
        // if heatlh is less than max health appply more life
        if (PlayerHealth <= Maxhealth)
        {
         
            // player health + value (health gain,from potionHealth.cs)
            PlayerHealth += value;

            // Fill amount
            Lives.fillAmount = PlayerHealth / 100;

            currentHealth += damage;
            healthbar.SetHealth(currentHealth);
        }
    }

    public void Decreaser(float value)
    {



    }
}
