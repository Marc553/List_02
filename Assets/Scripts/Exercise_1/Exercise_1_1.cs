using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_1_1 : MonoBehaviour
{
    public GameObject enemyPrefab; //enemy prefab
    private Vector3 SpawnPosition; //vector to save the created spawn position
    private float xRange = 8f; //limit spawn sides
    private float yRange = 4f; //limit spawn up/down
    private float randomY; //variabel that saves the random position in Y
    private float randomX; //variabel that saves the random position in X
    private int enemiesPerWave = 1; //varaible that says the number of the enemies per wave
    private int enemiesLeft; //checks the enemies left
    public Exercise_1_2 gameManager; //game manager script

    void Start()
    {
        SpawnEnemyWave(enemiesPerWave);//spawns the first wave
        gameManager = FindObjectOfType<Exercise_1_2>();//get the script of the game manager
    }

    private void Update()
    {
        enemiesLeft = FindObjectsOfType<Exercise_1_2>().Length;//check the enemies left
        if (enemiesLeft <= 0)//if there aren't any enemies left spawn more enemies
        {
            enemiesPerWave = gameManager.wave++;//1 enemy more than the last wave
            SpawnEnemyWave(enemiesPerWave);//do the function
        }
    }

    public Vector3 RandomSpawnPosition()//create a random position 
    {
        randomX = Random.Range(-xRange, xRange);//create a random x
        randomY = Random.Range(-yRange, yRange);//create a random y
        return new Vector3(randomX, randomY, 0);// return the random position
    }

    public void SpawnEnemy()
    {
        //randomIdex = Random.Range(0, enemyPrefab); //numero entre 0 y maximo numero d objetos d mi "animalPrefabs
        SpawnPosition = RandomSpawnPosition(); //saves the position createed in the other function
        Instantiate(enemyPrefab, SpawnPosition, enemyPrefab.transform.rotation); //instiate the enemy prefab in the random position 
    }

    public void SpawnEnemyWave(int totalenemies) //function that do the spawn enemies every time for every enemy spawned
    {
        for (int i = 0; i < totalenemies; i++)
        {
            SpawnEnemy();

        }
    }

}

