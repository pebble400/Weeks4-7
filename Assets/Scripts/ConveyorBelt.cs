using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update() //simple movement script to make the foods move across the screen while on the conveyor belt to make it look like the conveyor belt is the thing thats making the food move
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if(screenPos.x < 0)
        {
            Vector3 fixedPos = new Vector3 (0, 0 , 0);
            pos.x = Camera.main.WorldToScreenPoint(fixedPos).x;
            speed = speed * -1;
        }
        if(screenPos.x > Screen.width)
        {
            Vector3 fixedPos = new Vector3 (Screen.width, 0 , 0);
            pos.x = Camera.main.WorldToScreenPoint(fixedPos).x;
            speed = speed * -1;
        }
        transform.position = pos;
    }
}
