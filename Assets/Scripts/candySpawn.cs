using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candySpawn : MonoBehaviour
{

    GameObject[] candies;
    GameObject RandCandy;
    


    // Start is called before the first frame update
    void Start()
    {
        candies = GameObject.FindGameObjectsWithTag("Candy");
        for(int i = 0; i < candies.Length; i++)
        {
            Debug.Log(candies[i].name);
        }
        InvokeRepeating("spawn", 2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        RandCandy = candies[Random.Range(0, candies.Length)];
        float candyLocation = Random.Range(-4, 4);
        Debug.Log(candyLocation);

        transform.position = (new Vector3(Random.Range(-4, 4), 2, 0));
        


        
    }



    void spawn()
    {
        if (Time.frameCount < 32000) { 
        Instantiate(RandCandy, transform.position, Quaternion.identity);
        }
        
    }
}
