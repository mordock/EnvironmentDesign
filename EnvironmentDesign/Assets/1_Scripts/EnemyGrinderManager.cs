using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyGrinderManager : MonoBehaviour
{
    public List<GameObject> spawnPoints;
    public float spawnTime;
    public GameObject grinderObject;

    private float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if(currentTime <= 0) {
            Spawn();
            currentTime = spawnTime;
        }
    }

    private void Spawn() {
        int random = Random.Range(0, spawnPoints.Count);
        GameObject randomPoint = spawnPoints[random];

        Instantiate(grinderObject, randomPoint.transform);
    }
}
