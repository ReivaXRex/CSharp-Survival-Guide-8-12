using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Define the traits of a spell.
/// </summary>
[System.Serializable]
public class Spell 
{
    public string spellName;
    public int levelRequired;
    public int itemIdRequired;
    public int expGained;

    // Constructor to initialize values.
    public Spell(string spellname, int levelRequired, int itemIdRequired, int expGained)
    {
        this.spellName = spellname;
        this.levelRequired = levelRequired;
        this.itemIdRequired = itemIdRequired;
        this.expGained = expGained;
    }

    public void Cast()
    {
        Debug.Log("Casting: " + spellName);
    }
}
