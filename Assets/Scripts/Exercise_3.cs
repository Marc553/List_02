using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise_3 : MonoBehaviour
{

    public GameObject pivot;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            pivot.transform.position = new Vector3(2, 0, 1);
        }
        
        if(Input.GetKeyDown(KeyCode.W))
        {
            pivot.transform.position = new Vector3(0, 2, 1);
        }
        
        if(Input.GetKeyDown(KeyCode.A))
        {
            pivot.transform.position = new Vector3(-2, 0, 1);
        }
        
        if(Input.GetKeyDown(KeyCode.S))
        {
            pivot.transform.position = new Vector3(0, -2, 1);
        }
    }



}
