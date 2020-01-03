﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject[] trianglePrefabs;
    private Vector3 spawnObstaclePosition;
    
    


    void Update()
    {
        float distanceToHorizon = Vector3.Distance(player.gameObject.transform.position, spawnObstaclePosition);

        if (distanceToHorizon < 120)
        {
            spawnTriangles();
        }
    }

    void spawnTriangles()
    {
        spawnObstaclePosition = new Vector3(0, 0, spawnObstaclePosition.z + 20);
        Instantiate(trianglePrefabs[(Random.Range(0, trianglePrefabs.Length))], spawnObstaclePosition, Quaternion.identity);
    }
}
