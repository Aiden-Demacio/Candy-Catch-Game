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
        InvokeRepeating("Spawn", 2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        RandCandy = candies[Random.Range(0, candies.Length)];
    }



    void spawn()
    {
        Instantiate(RandCandy, transform.position, Quaternion.identity);
    }
}
