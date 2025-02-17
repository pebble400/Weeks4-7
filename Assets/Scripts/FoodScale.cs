using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScale : MonoBehaviour
{   //my unfortunate attempt at trying to make the food sprites have a scale value that can be controlled via a slider
    //this was the scaling script that I tried to reference in the spawners, I thought it would work since the spawners have a reference to the prefabs but the slider needs an object thats from the hierarchy and putting the prefabs in the hierarchy would just break the whole thing, I know why that is but I just can't seem to figure out another way to make that reference
    public float sizeScale = 1f;//added this just to test if the scaling script even works and at the very least, it does. Can be found attached to the burger prefab
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = new Vector3(sizeScale, sizeScale);
        transform.localScale = scale;
    }
}
