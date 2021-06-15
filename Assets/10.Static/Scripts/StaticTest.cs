using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    string itemName;
    string itemID;

    public static int itemCount;

    public Item()
    {
        itemCount++;
    }
}

public class StaticTest : MonoBehaviour
{
    void Start()
    {
        Item sword = new Item();
        Item cape = new Item();
        Item bread = new Item();
        Item fish = new Item();

        Debug.Log("Item Count: " + Item.itemCount);
    }

}
