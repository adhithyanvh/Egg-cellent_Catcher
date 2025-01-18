using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject eggPrefab;

    public GameObject[] eggs;
    public int eggSelector;
    public float spawnRepeater = 2f;
    public int counter = 10;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EggSpawn", 3f, spawnRepeater);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EggSpawn()
    {
        eggSelector = Random.Range(0, eggs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-8f, 8f), 10f, 0f);
        Instantiate(eggs[eggSelector], spawnPos, eggPrefab.transform.rotation);

        if (CollisionDetect.score / counter == 1)
        {
            spawnRepeater = spawnRepeater - 0.2f;
            counter = counter + 10;
            Debug.Log(counter);
        }
    }
}

