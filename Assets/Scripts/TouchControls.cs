using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
    float screenWidth = Screen.width;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Touch touch = Input.GetTouch(0);
        if (touch.position.x > (screenWidth / 2))
        {
           // rb.AddForce(Vector3.right * turnSpeed);
        }
        else
        {
            //The user hase touched the left side of the screen 
        }
    }
}
