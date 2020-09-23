using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipeparent;
    public float spawnrate = 1f;
    public float nexttimeToSpawn = 0f;
    public Vector3 startingpoint;
    public float timeseparater = 1f;

    // Update is called once per frame
    void Update()
    {
        if(BirdMovement.start == true)
        {
if(BirdMovement.gameover == false && Time.time >= nexttimeToSpawn)
            {
                startingpoint.y = Random.Range(0.5f, -4f);
                Instantiate(Pipeparent, startingpoint, Quaternion.identity);
        
                nexttimeToSpawn = Time.time + timeseparater;
            }
        }

    }
    

   
}
