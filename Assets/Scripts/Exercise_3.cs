using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise_3 : MonoBehaviour
{
    private Vector3 x = new Vector3(2, 0, 0);//vector that is X=2
    private Vector3 y = new Vector3(0, 2, 0);//vector that is Y=2
    private float xRange = 4;//limit to the X
    private float yRange = 4;//limit to the Y
    public GameObject pivot;//game object that will be moving 

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))//moves 2 points to x pressing D
        {
            pivot.transform.position += x ;
        }

        if(Input.GetKeyDown(KeyCode.A))//moves 2 points to -x pressing A
        {
            pivot.transform.position -= x;
        }

        if(Input.GetKeyDown(KeyCode.W))//moves 2 points to y pressing W
        {
            pivot.transform.position += y;
        }
        
        
        if(Input.GetKeyDown(KeyCode.S))//moves 2 points to -y pressing S
        {
            pivot.transform.position -= y;
        }

        //right limit screen 
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //left limit screen 
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //up limit screen 
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }

        //down limit screen 
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }
    }
}
