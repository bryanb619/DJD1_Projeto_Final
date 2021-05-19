using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralManager : MonoBehaviour
{   // instancia, para ser acessível de qualquer lado
    // Este ficheiro é muito referenciado
    public static GeneralManager  instance;
    public Transform respawnPos;
    public GameObject playerPrefab;

    private void Wake()
    {
        instance = this;
    }  
    // method de respawn
    public void Respawn()
    {
        Instantiate(playerPrefab, respawnPos.position, Quaternion.identity);
    }
    
}
