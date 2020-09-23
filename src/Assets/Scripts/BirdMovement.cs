using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpheight;
    public static bool gameover = false;
    public Vector2 vel;
    public GameObject bird;
    public static bool start;
    public GameObject menu;
    public GameObject currentscoretext;
    public GameObject currenthighscoretext;
    public Animator anim;
    public GameObject animationstation;


    private void Start()
    {
        start = false;
        GameManagement.score = 0;
        Physics2D.gravity = new Vector3(0, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        if (start == false && Input.GetKeyDown(KeyCode.Space))
        {
            start = true;
            anim.SetBool("betterendbirdanim", true);
            anim.enabled = false;

            Physics2D.gravity = new Vector3(0, -9.81f, 0);
        }

        vel = rb.velocity;
        if (start == true && gameover == false)
        {
            vel = rb.velocity;
            if (Input.GetKeyDown(KeyCode.Space) && gameover == false)
            {
                if ((-vel.y + 10) > 0)
                {
                    rb.AddForce(Vector2.up * jumpheight * ((-vel.y + 10) / 3));
                }
              
            }
            if (vel.y < 0)
            {
                bird.transform.eulerAngles = new Vector3(bird.transform.eulerAngles.x, bird.transform.eulerAngles.y, -45);
            }
            if (vel.y > 0)
            {
                bird.transform.eulerAngles = new Vector3(bird.transform.eulerAngles.x, bird.transform.eulerAngles.y, 45);
            }
        }



    }

    private void OnCollisionEnter2D(Collision2D col)
    {
       if (col.gameObject.tag == "pipe" || col.gameObject.tag == "bottompipe" || col.gameObject.tag == "ground" || col.gameObject.tag == "ceiling")
        {
            gameover = true;
            menu.SetActive(true);
            currentscoretext.SetActive(false);
        }
    }
}
