using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats
{
    public string name;
    public float fireRate;
    public int ammoCount;

    public WeaponStats(string _name, float _fireRate, int _ammoCount)
    {
        // name = "Blasters";
        // fireRate = 0.25f;
        // ammoCount = 50;
        name = _name;
        fireRate = _fireRate;
        ammoCount = _ammoCount;
    }
}

public class ClassesPlayer : MonoBehaviour
{
    private WeaponStats blasters;
    private WeaponStats rockets;

    private void Start()
    {
        blasters = new WeaponStats("Blasters", 0.25f, 50);
        rockets = new WeaponStats("Rockets", 5.0f, 1);

        Debug.Log("Current Weapon Name: " + blasters.name);
        // blasters = new WeaponStats();
        // blasters.name = "Blasters";
        // blasters.fireRate = 0.25f;
        // blasters.ammoCount = 50;

        // rockets = new WeaponStats();
        // rockets.name = "Rockets";
        // rockets.fireRate = 5.0f;
        // rockets.ammoCount = 1;
    }

}

 