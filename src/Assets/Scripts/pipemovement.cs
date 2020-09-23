using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemovement : MonoBehaviour
{
    public Vector3 vel;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = new Vector3(-3f, 0, 0);
        Invoke("destruction", 8);
    }


    void Update()
    {
        if (BirdMovement.gameover == true)
            rb.velocity = new Vector3(0, 0, 0);


    }


    void destruction()
    {
       // if (BirdMovement.gameover == false)
         //  Destroy(gameObject);
    }
}
