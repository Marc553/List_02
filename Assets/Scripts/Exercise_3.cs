using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise_3 : MonoBehaviour
{
    private Vector3 x = new Vector3(2, 0, 0);
    private Vector3 y = new Vector3(0, 2, 0);
    private float xRange = 4;
    private float yRange = 4;
    public GameObject pivot;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            pivot.transform.position += x ;
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            pivot.transform.position -= x;
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            pivot.transform.position += y;
        }
        
        
        
        if(Input.GetKeyDown(KeyCode.S))
        {
            pivot.transform.position -= y;
        }

        //Limite de pantalla por la derecha
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Limite de pantalla por la izquierda
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
        //Limite de pantalla por la derecha
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }

        //Limite de pantalla por la izquierda
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }

        


    }



}
