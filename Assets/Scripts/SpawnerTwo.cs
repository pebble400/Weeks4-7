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
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newFood = Instantiate(prefab);

            Destroy(newFood, 6);
        }
    }
}
