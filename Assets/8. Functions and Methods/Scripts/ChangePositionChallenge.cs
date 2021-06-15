using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePositionChallenge : MonoBehaviour
{
    [SerializeField] Vector3[] positions =  new Vector3[5];
    public int randomIndex;

    void Start()
    {
        CreatePositions();             
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            randomIndex = GetRandom();
            transform.position = GetPosition(randomIndex);
        }
    }

    /// <summary>
    /// Create and assign a random variable for each axis of the Vector3 within the array.
    /// </summary>
    public void CreatePositions()
    {
        for (int i = 0; i < positions.Length; i++)
        {
            float randomPosX = Random.Range(0, 10);
            float randomPosY = Random.Range(0, 10);
            float randomPosZ = Random.Range(0, 10);
            positions[i] = new Vector3(randomPosX, randomPosY, randomPosZ);

        }
    }

    /// <summary>
    /// Return a random int number ranging from 0 to the length of the array.
    /// </summary>
    /// <returns>
    ///Random int value
    /// </returns>
    int GetRandom()
    {
        return Random.Range(0, positions.Length);
    }

    /// <summary>
    /// Returns one of the randomized positions within the array.
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    Vector3 GetPosition(int index)
    {
        return positions[index];
    }
}
