using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodSyntax : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start()");
        MyMethod(); // Method Call
        Debug.Log("Completed calling MyMethod");
    }

    private void MyMethod() // Method Delcaration
    {
        Debug.Log("MyMethod()");
    }
}
