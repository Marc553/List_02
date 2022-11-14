using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_1_2 : MonoBehaviour
{
    public int wave;//variable with the points that will be added

    public Exercise_1_1 gameManager; //game manager script

    private void OnMouseDown()//function that do the objects clicked with the mouse 
    {
        
        Destroy(gameObject);//destroy the game object that has clicked
    }
}
