using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    private float zBoundary = 24;
    private float xBoundary = 24;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefabs[0], GetRandomLocation(), enemyPrefabs[0].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 GetRandomLocation() { 
        return new Vector3(Random.Range(-xBoundary, xBoundary), 0, Random.Range(-zBoundary, zBoundary));
    }
}
