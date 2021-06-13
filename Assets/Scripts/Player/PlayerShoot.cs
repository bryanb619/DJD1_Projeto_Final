using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    // Variables
    // Fire shooting location
    public Transform FirePos;
    // Fire ball object
    public GameObject Fire;

    // Update is called once per frame
    void Update()
    {
        //player input (Left mouse (0 por default))
        if (Input.GetButtonDown("Fire1"))
        {
            // calling shoot method
            shoot();

        }
        // Fire shooting mehtod
        void shoot()
        {
            // creeate Fireball 
            Instantiate(Fire, FirePos.position, FirePos.rotation);

        }
    }
}
