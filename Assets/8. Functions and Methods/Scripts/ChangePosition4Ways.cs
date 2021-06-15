using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition4Ways : MonoBehaviour
{
    void Start()
    {
        // Method 1
        transform.position = new Vector3(0, 0, 0);

        // Method 2 (Method)
        ChangePosition();
        
        // Method 3 (Void Method w/ parameters)
        ChangePosition(Vector3.zero); // || new Vector3(0,0,0);

        // Method 4 (Return type)
        transform.position = GetPositon();

        // Method 4.5 (Optimal Return Type)
        transform.position = GetPosition(0,0,0);
    }

    public void ChangePosition() // Method 2
    {
        
        transform.position = Vector3.zero;
    }

    public void ChangePosition(Vector3 pos) // Method 3
    {
        transform.position = pos;
    }

    
    public Vector3 GetPositon() // Method 4
    {                           // Vector3 pos
        return Vector3.zero;    
    }

    public Vector3 GetPosition(float x, float y, float z) // Method 4.5
    {
        // return new Vector3(x, y, z);
        
        Vector3 pos = new Vector3(x, y, z); // Handle operation
        return pos; // return position
    }
}
