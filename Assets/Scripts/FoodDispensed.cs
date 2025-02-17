using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FoodDispensed : MonoBehaviour
{
    public TextMeshProUGUI foodDispensed; //simple click counter, isn't accurate to how many food sprites are actually on screen but at least it give the illusion that something is being counted
    int foodDispensedValue = 0;


    private void Start()
    {
        foodDispensed.text = foodDispensedValue.ToString();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            foodDispensedValue++;
            foodDispensed.text = foodDispensedValue.ToString();
        }
    }
}

