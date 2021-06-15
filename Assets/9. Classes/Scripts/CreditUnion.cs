using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CreditUnion : Bank
{
    public int cashToLend;

    public void ApproveLending()
    {
        Debug.Log("You are awarded a loan.");
    }
}
