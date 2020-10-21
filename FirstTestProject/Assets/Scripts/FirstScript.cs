using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //The line will be outputted once before the first frame update
        print("Welcome SWD4.2B");
    }

    // Update is called once per frame
    void Update()
    {
        //The line will be outputted with every frame (Example: if running at 30FPS, the line will be outputted 30 times per second
        print("Hello!");
    }
}
