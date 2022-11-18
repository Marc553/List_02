using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Exercise_2 : MonoBehaviour
{
    public TextMeshProUGUI timerText;//text where the time will be showed
    private float courrentTimer;//save the current time 
    public float maxTimer;//sets the max time
    public Image image;//the image that will be the "slider"

    private void Start()
    {
        courrentTimer = maxTimer;//gives the max time to the current time, to set it
    }
    void Update()
    {
       if(courrentTimer >= 0)//if the current time goes 0, the time will stop
        {
            courrentTimer -= Time.deltaTime;//reduces 1 by 1 at real time

        timerText.text = "" + courrentTimer.ToString("f0");//te timer will show the current time ,limited by 1 only number

        }

        image.fillAmount = courrentTimer/maxTimer;// fix the reduction of current time respect to the max time to the image "slider"
    }
}
