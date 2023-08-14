using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    //[SerializeField]
   // private float minimumSpawnTime;

    [SerializeField]
    private float enemyInterval = 3.5f;

    /*[SerializeField]
    private float maximumSpawnTime;

    private float timeUntilsSpawn;*/

    
    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab));
    }
    private IEnumerator spawnEnemy(float Interval,GameObject enemy)
    {
        yield return new WaitForSeconds(Interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5),Random.Range(-6f, 6f), 59.325f),Quaternion.identity);
        StartCoroutine(spawnEnemy(Interval, enemy));
    }
   /* void Awake()
    {
        SetTimeUntilSpawn();
    }
   
    void Update()
    {
        timeUntilsSpawn -= Time.deltaTime;
        if (timeUntilsSpawn <= 0)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }
    private void SetTimeUntilSpawn()
    {
        timeUntilsSpawn = Random.Range(minimumSpawnTime,maximumSpawnTime);
    }*/
}
