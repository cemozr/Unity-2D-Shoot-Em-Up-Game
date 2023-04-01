using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScEnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject skeletonPrefab;
    [SerializeField] private GameObject zombiePrefab;
    

    [SerializeField] private float skeletonSpawnRate = 10.0f;
    [SerializeField] private float zombieSpawnRate = 5.0f;
    
   
    void Start()
    {
       StartCoroutine(spawnEnemy(skeletonSpawnRate, skeletonPrefab)); 
       StartCoroutine(spawnEnemy(zombieSpawnRate, zombiePrefab)); 
       
    }

 private IEnumerator spawnEnemy(float spawnRate,GameObject enemy)
{
    yield return new WaitForSeconds(spawnRate);
    GameObject newEnemy = Instantiate(enemy,new Vector3(Random.Range(-10f,10), Random.Range(-10f, 10), 0),Quaternion.identity);
    
StartCoroutine(spawnEnemy(spawnRate, enemy));
}
}
