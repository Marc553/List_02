using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_1_1 : MonoBehaviour
{
    public GameObject enemyPrefab;
    private Vector3 SpawnPosition;
    private float xRange = 8f;
    private float yRange = 4f;
    private float randomY;
    private float randomX;
    private int enemiesPerWave = 1;
    private int enemiesLeft;
    public Exercise_1_2 gameManager; //game manager script

    //private int randomIdex;
    void Start()
    {
        SpawnEnemyWave(enemiesPerWave);
        gameManager = FindObjectOfType<Exercise_1_2>();//get the script of the game manager
    }

    private void Update()
    {
        enemiesLeft = FindObjectsOfType<Exercise_1_2>().Length;
        if (enemiesLeft <= 0)
        {
            enemiesPerWave = gameManager.wave++;
            SpawnEnemyWave(enemiesPerWave);
        }
    }

    public Vector3 RandomSpawnPosition()
    {
        randomX = Random.Range(-xRange, xRange);
        randomY = Random.Range(-yRange, yRange);
        return new Vector3(randomX, randomY, 0);
    }

    public void SpawnEnemy()
    {
        //randomIdex = Random.Range(0, enemyPrefab); //numero entre 0 y maximo numero d objetos d mi "animalPrefabs
        SpawnPosition = RandomSpawnPosition();
        Instantiate(enemyPrefab, SpawnPosition, enemyPrefab.transform.rotation);
    }

    public void SpawnEnemyWave(int totalenemies)
    {
        for (int i = 0; i < totalenemies; i++)
        {
            SpawnEnemy();

        }
    }

}

