using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScale : MonoBehaviour
{
    public float sizeScale = 1f;
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
