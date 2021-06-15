using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityHelper 
{
    public static void CreateObject()
    {
        // Create a new primitive cube.
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    public static void SetPositionToZero(GameObject obj)
    {
        // Change position of obj.
        obj.transform.position = Vector3.zero;
    }
}
