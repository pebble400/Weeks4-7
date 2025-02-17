using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerThree : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newFood = Instantiate(prefab);//pizza spawner 

            Destroy(newFood, 7);//same thing as the chicken, made it move slower so it doesn't overlap which meant I had to adjust the despawning time
        }
    }
}
