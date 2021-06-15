using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoProperties : MonoBehaviour
{
    public bool isGameOver { get; set; } // Can't run function code within.
   
    // public bool isGameOver { get; private set; } // Objects in the game can read the value but not set it.
   
    // public bool isGameOver { get; protected set; } // Only classes that derive this class can set the value.

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;

        if (isGameOver)
        {
            // run code...
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          // Run code..
        }
    }
}
