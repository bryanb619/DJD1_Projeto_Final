using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform FirePos;
    public GameObject Fire;

    // Update is called once per frame
    void Update()
    {
        //player input (rato, lado esquerdo(0 por default))
        if (Input.GetButtonDown("Fire1"))
        {
            // calling do método
            shoot();

        }
        // Código de disparo
        void shoot()
        {
            Instantiate(Fire, FirePos.position, FirePos.rotation);

        }


    }
}
