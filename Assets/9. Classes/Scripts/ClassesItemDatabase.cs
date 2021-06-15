using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassesItemDatabase : MonoBehaviour
{    
    ClassesItems sword;
    ClassesItems hammer;
    ClassesItems bread;

   
    void Start()
    {
        // Create a weapon through three different ways.

        sword = new ClassesItems();
        sword.itemName = "Sword";
        sword.itemID = 1;
        sword.itemDescription = "An iron short sword.";

        hammer = new ClassesItems("Hammer", "A smith's hammer", 2);
        
        
        bread = CreateItem("bread", "A loaf of bread", 2);

        // CreateItem("bread", "A loaf of bread", 2);
    }

    private ClassesItems CreateItem(string name, string description, int id)
    {
        ClassesItems item = new ClassesItems(name, description, id);
        return item;
    }


   // public ClassesItems[] items; 

}
