using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    // Health bar image
    public Image Lives;
    private int PlayerHealth = 100;
    public void LoseLife(int value)
    {
        if(PlayerHealth <=0)
        {
            return;
        }
        PlayerHealth -= value;
        Lives.fillAmount = PlayerHealth / 100;

        if(PlayerHealth <=0)
        {
            Debug.Log("Health is at 0%");
            FindObjectOfType<Player>().PlayerDeath();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

