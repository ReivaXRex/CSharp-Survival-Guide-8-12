using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private UIManager _UIManager;
    public void OnEnable()
    {
        SpawnManager.enemyCount++;
        _UIManager = GameObject.Find("UI Manager").GetComponent<UIManager>();
        _UIManager.UpdateEnemyCount();
        Die();
    }

    public void OnDisable()
    {
        SpawnManager.enemyCount--;
        _UIManager.UpdateEnemyCount();
    }

    void Die()
    {
        Destroy(this.gameObject, Random.Range(2,5));
    }

}
