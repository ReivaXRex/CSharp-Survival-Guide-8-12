using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ClassesItems 
{
    public string itemName;
    public string itemDescription;
    public int itemID;

    public ClassesItems()
    {

    }

    public ClassesItems(string _name, string _description, int _itemID)
    {
        itemName = _name;
        itemDescription = _description;
        itemID = _itemID;
    }

}
