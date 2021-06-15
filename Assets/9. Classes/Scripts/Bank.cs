using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bank
{
    [SerializeField] protected string branchName;
    [SerializeField] protected string location;
    [SerializeField] protected int cashInVault;

    public void CheckBalance()
    {
        Debug.Log("Checking Balance at " + branchName);
    }

    public void Withdrawl()
    {
        Debug.Log("Withdrawing money from " + branchName);
    }

    public void Deposit()
    {
        Debug.Log("Depositing money into " + branchName);
    }
}
