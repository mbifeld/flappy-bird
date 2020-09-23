using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAnimationScript : MonoBehaviour
{

    public Animator anim;
   

    // Update is called once per frame
    void Update()
    {
        if (BirdMovement.start == true)
        {
            anim.SetBool("StartingAnim", true);
        }
    }
}
