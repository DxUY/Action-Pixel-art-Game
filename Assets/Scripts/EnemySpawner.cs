using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _darkBatPrefabs;

    private float _countDownTime = 2f;
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    
    void Update()
    {
        
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            Instantiate(_darkBatPrefabs, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(_countDownTime);    
        }
        
    }
}
