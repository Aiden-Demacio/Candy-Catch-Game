using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candySpawn : MonoBehaviour
{

    GameObject[] candies;

    


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
        
    }



    void spawn()
    {
        Instantiate(candies[Random.Range(0, candies.Length)], transform.position, Quaternion.identity);
    }
}
