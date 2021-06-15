using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorFunction : MonoBehaviour
{
 
    public GameObject colorCube;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor(colorCube, Color.green);
        }
    }

    /// <summary>
    /// Change the color of the passed in gameObject to the specified color.
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="newColor"></param>
    private void ChangeColor(GameObject obj, Color newColor)
    {
        obj.GetComponent<MeshRenderer>().material.color = newColor;
    }
}
