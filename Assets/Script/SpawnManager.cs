using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefabs;
    private float spawnRange = 9;
    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate(enemyPrefabs, GenerateSpawn(), enemyPrefabs.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        

    }
    private Vector3 GenerateSpawn()
    {
        float spawnPosx = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosx, 0, spawnPosZ);
        return randomPos;

    }
}
