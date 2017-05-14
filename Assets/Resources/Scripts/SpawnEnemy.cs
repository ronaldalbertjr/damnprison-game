﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField]
    Transform[] spawnPoints;
    [SerializeField]
    GameObject[] enemy;

    public void Instantiate()
    {
        Instantiate(enemy[Random.Range(0, enemy.Length)], spawnPoints[Mathf.FloorToInt(Random.Range(1, 4))].position, new Quaternion(0, 0, 0, 0));
    }
}
