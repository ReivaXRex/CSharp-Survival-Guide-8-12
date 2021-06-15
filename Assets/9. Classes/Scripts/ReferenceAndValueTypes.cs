using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestItem // REFERENCE TYPE -- Stored in the HEAP
{
    public string testItemName;
    public int testItemID;

    public TestItem(string name, int id)
    {
        this.testItemName = name;
        this.testItemID = id;
    }
}

public struct TestItem2 // VALUE TYPE -- Stored in the STACK
{
    public string testItemName;
    public int testItemID;

    public TestItem2(string name, int id)
    {
        this.testItemName = name;
        this.testItemID = id;
    }
}


public class ReferenceAndValueTypes : MonoBehaviour
{
    // Declaration
    TestItem sword = new TestItem("Sword", 1);
    TestItem2 bread; // No need to create an instance, it automatically exists since it's a value type.

    void Start()
    {
        bread.testItemName = "Bread";
        bread.testItemID = 2;
        Debug.Log("Current bread name: " + bread.testItemName);
        ChangeValue(bread);

        Debug.Log("Current bread name (after method): " + bread.testItemName);
        
        Debug.Log(sword.testItemName);
        ChangeValue(sword);
        Debug.Log(sword.testItemName);
    }

    void ChangeValue(TestItem2 structItem) // value type
    {
        structItem.testItemName = "Dirty Bread";
        Debug.Log(structItem.testItemName);
    }

    /// <summary>
    /// Change the name of the Sword item.
    /// </summary>
    /// <param name="classItem"></param>
    void ChangeValue(TestItem classItem) // reference type
    {
        classItem.testItemName = "Master Sword";
    }
}
