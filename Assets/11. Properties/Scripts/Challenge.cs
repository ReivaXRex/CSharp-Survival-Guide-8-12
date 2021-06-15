using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge : MonoBehaviour
{
    public int speed { get; private set; }
    public string challengeName { get; set; }

    public string challengeName2
    {
        get
        {
            return "X";
        }
        set
        {
            if (value == "X")
            {
                Debug.Log("Hello Xavier");
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
