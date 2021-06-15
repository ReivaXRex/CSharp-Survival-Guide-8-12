using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertiesChallenge : MonoBehaviour
{
    private float _playerSpeed;
    // public float _playerSpeed { get; private set; } read only 
    public float playerSpeed { get { return _playerSpeed; } private set { _playerSpeed = value; } }

    private string playerName;
    public string _playerName { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        playerSpeed = 10.0f;
        Debug.Log(playerSpeed);

        _playerName = "Xavier";
        Debug.Log(_playerName);
    }

}
