using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] float timeRemaining = 1.5f;

    public GameObject enemyPrefab;
    public Transform[] spawnPosition;
    public int spawnIndex = 0;
    public int enemyType = 1;
    
    void FixedUpdate()
    {
        if(timeRemaining <= 0)
        {
            timeRemaining = 1.5f;

            GameObject enemy = PoolManager.Instance.GetPooledObjects(enemyType, spawnPosition[spawnIndex].position, spawnPosition[spawnIndex].rotation);
            enemy.SetActive(true);
            spawnIndex++;
            if(spawnIndex == 5)
            {
                spawnIndex = 0;
            }

        }
        else 
        {
            timeRemaining -= Time.fixedDeltaTime;
        }
    }
}
