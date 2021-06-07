using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    public Image Lives;
    public int PlayerHealth;
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
            FindObjectOfType<PlayerControls>().PlayerDeath();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
