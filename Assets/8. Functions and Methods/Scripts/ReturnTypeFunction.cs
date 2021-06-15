using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnTypeFunction : MonoBehaviour
{
    int total01;
    int total02;

    void Start()
    {
        total01 = Sum(10, 2); // 10 stored in 'a', 2 in 'b'
        total02 = Sum(3, 5);    // 3 stored in 'a', 5 in 'b'
        Debug.Log("Total01 = " + total01 + " " + "Total02 = " + total02);
    }

    /// <summary>
    /// Returns the sum of the two values set for the parameters.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public int Sum(int a, int b)
    {
        return a + b;
    }

    
}
