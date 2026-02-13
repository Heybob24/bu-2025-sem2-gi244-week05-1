
using System;
using UnityEngine;

[Serializable]
public class Wave
{
    public GameObject[] eneyPrefabs;
    public int enemycount;
    public float spawnInterval = 1f;
    public float waveInterval = 5f;
}