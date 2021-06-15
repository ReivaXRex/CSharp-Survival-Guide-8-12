using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnArray : MonoBehaviour
{
    //  A custom method to dynamically populate an array of GameObjects with a specific tag.

    public GameObject[] players;

    void Start()
    {
        players = GetAllPlayers();
    }

    GameObject[] GetAllPlayers()
    {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");

        foreach (var player in allPlayers)
        {
            player.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }

        return allPlayers;
    }
}
