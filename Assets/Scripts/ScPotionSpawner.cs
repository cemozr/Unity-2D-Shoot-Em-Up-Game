using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScPotionSpawner : MonoBehaviour
{

    [SerializeField] private GameObject redPotionPrefab;
    [SerializeField] private GameObject purplePotionPrefab;
    [SerializeField] private GameObject firePotionPrefab;

    [SerializeField] private float redPotionSpawnRate = 10.0f;
    [SerializeField] private float purplePotionSpawnRate = 5.0f;
    [SerializeField] private float firePotionSpawnRate = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(spawnPotion(redPotionSpawnRate, redPotionPrefab)); 
       StartCoroutine(spawnPotion(purplePotionSpawnRate, purplePotionPrefab)); 
       StartCoroutine(spawnPotion(firePotionSpawnRate, firePotionPrefab)); 

       
    }

private IEnumerator spawnPotion(float spawnRate,GameObject potion)
{
    yield return new WaitForSeconds(spawnRate);
    GameObject newPotion = Instantiate(potion,new Vector3(Random.Range(-10f,10), Random.Range(-10f, 10), 0),Quaternion.identity);
    
StartCoroutine(spawnPotion(spawnRate, potion));
}
}
