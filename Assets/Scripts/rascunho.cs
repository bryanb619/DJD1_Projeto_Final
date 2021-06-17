using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rascunho : MonoBehaviour
{
    [SerializeField]
    private Transform FirePos;

    [SerializeField]
    private GameObject Fire;

    [SerializeField]
    private GameObject[] ammo;

    private int ammoAmount;

    public float cooldownTime = 3;

    private float nextFireTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 2; i++)
        {
            ammo[i].gameObject.SetActive(false);
        }

        ammoAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFireTime)
        {
            if (Input.GetButtonDown("Fire1") && ammoAmount > 0)
            {
                var spawedFire = Instantiate(Fire, FirePos.position, FirePos.rotation);
                spawedFire.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 500f);
                ammoAmount -= 1;
                ammo[ammoAmount].gameObject.SetActive(false);

                nextFireTime = Time.time + cooldownTime;

            }

            if (Input.GetKey(KeyCode.R))
            {
                ammoAmount = 3;
                for (int i = 0; i <= 2; i++)
                {
                    ammo[i].gameObject.SetActive(true);
                }

                nextFireTime = Time.time + cooldownTime;
            }
        }  
    }
}
