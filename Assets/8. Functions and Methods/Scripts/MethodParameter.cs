using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodParameter : MonoBehaviour
{
    // Simple damage function using a custom method.
   
    [SerializeField] int health = 10;

    /// <summary>
    /// When called, pass in the amount of damage to be dealt.
    /// Made Public so it can be called by other scripts like an Enemy for example.
    /// </summary>
    /// <param name="damageAmount"></param>
   

    public void Damage(int damageAmount) 
    {
        health -= damageAmount; 
        if (health < 1)
        {
            health = 0;
            Debug.Log(this.name + " has died.");
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage(2);
        }
        
    }
}
