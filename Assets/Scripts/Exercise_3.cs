using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_3 : MonoBehaviour
{
    private float minX = -3.75f;
    private float minY = -3.75f;
    private float distanceBetweenSquares = 2.5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 RandomSpawnPosition()
    {
        int SaltoX = Random.Range(0, 4);
        int SaltoY = Random.Range(0, 4);

        float spawnPosX = minX + SaltoX * distanceBetweenSquares;
        float spawnPosY = minY + SaltoY * distanceBetweenSquares;

        return new Vector3(spawnPosX, spawnPosY, 0);
    }
}
