using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HelperMethods 
{
    public static void ObjectColorChange(GameObject obj)
    {
        obj.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
