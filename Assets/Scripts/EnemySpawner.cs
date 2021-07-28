﻿using UnityEngine;
using UnityEngine.Networking;

public class EnemySpawner : NetworkBehaviour {

    public GameObject enemyPrefab;
    public int numberOfEnemies;

    public override void OnStartServer()
    {
        InvokeRepeating("SpawnCube", 1.0f, 20.0f);
    }
    public void SpawnCube()
    {
        if (isServer)
        {
            for (int i = 0; i < numberOfEnemies; i++)
            {
                var spawnPosition = new Vector3(Random.RandomRange(-50.0f, 50.0f), 0.0f, Random.Range(-50.0f, 50.0f));

                var spawnRotation = Quaternion.Euler(0.0f, Random.Range(0, 180), 0.0f);

                var enemy = (GameObject)Instantiate(enemyPrefab, spawnPosition, spawnRotation);
                NetworkServer.Spawn(enemy);
            }
        }
    }

}
