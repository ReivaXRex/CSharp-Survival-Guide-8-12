using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasDiedChallenge : MonoBehaviour
{
    [SerializeField] int health = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsDead() == false)
        {
            Damage(Random.Range(1, 5));

        }
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        Debug.Log("Damage: " + damageAmount);
        if (IsDead() == true)
        {
            health = 0;
            Debug.Log(this.name + " has died.");
        }
    }

    public bool IsDead()
    {
        return health < 1;
    }
}
