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
    private float CurrentDamageTime;
    //
    

    // loss of health method
    public void LoseLife(int value)
    {
        if(PlayerHealth <=0)
        {
            return;
        }
        PlayerHealth -= value;
        Lives.fillAmount = PlayerHealth / 100;
        // kill player
        if(PlayerHealth <=0)
        {
            Debug.Log("Health is at 0%");

            // find player death in Player.cs
            FindObjectOfType<Player>().PlayerDeath();
        }
    }
 

}

