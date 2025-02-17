using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;//I assigned all four spawners to their respective buttons to make it so that you can enable and disable each spawner in order to have control on what gets spawned and what doesn't
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           GameObject newFood = Instantiate(prefab);//spawns the burger prefab

           // FoodScale myScale = newFood.GetComponent<FoodScale>(); //this was my attempt at trying to get the food scale script to somehow link to the spawner script so that I could've put it onto a slider UI and change the food size using the slider but I couldn't get it to work

           // if(myScale != null)
           // {
               // myScale.sizeScale;
            //}

            Destroy(newFood, 5); // destroys the burger after five seconds
        }
    }
}
