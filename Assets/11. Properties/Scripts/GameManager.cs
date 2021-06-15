using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isGameOver;
    // public bool isGameOver;
    public bool IsGameOver // Create property
    {
        get // return the value of isGameOver;
        {
            return isGameOver;
        }
        set 
        {
            if (value == true)
            {
                Debug.Log("Game Over!");
            }
        }
    }

    void Start()
    {
        isGameOver = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // GameOver();
            IsGameOver = true;
        }
    }

    /* public void GameOver()
     * {
     *      isGameOver = true;
     * }
     */
}
