using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Exercise_2 : MonoBehaviour
{
    public TextMeshProUGUI timerText;//twxt where the score will be showed
    private float courrentTimer;
    public float maxTimer;
    public Image image;

    private void Start()
    {
        courrentTimer = maxTimer;
    }
    void Update()
    {
       if(courrentTimer >= 0)
        {
            courrentTimer -= Time.deltaTime;

        timerText.text = "" + courrentTimer.ToString("f0");

        }

        image.fillAmount = courrentTimer/maxTimer;
    }
}
