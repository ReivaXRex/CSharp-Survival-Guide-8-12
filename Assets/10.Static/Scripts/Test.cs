using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // private Score _score; Non static variable.
    void Start()
    {
       // _score = GameObject.Find("Score Keeper").GetComponent<Score>(); // Method to access the variable if it's not static.
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Score.score += 10;
            Debug.Log(Score.score);
        }
    }
}
