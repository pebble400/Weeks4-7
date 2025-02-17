using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTwo : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // spawner for the chicken prefab 
        {
            GameObject newFood = Instantiate(prefab);

            Destroy(newFood, 6); //distroys it after 6 seconds because I made the chicken move slower than the burger so they don't fully overlap
        }
    }
}
