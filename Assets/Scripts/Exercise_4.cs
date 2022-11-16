
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Exercise_4 : MonoBehaviour
{
    public string[] anwserA;
    public string[] anwserB;

    public int anwserNum = 0;
    public int counterAnswer = 0;

    public TextMeshProUGUI a;
    public TextMeshProUGUI b;
    public TextMeshProUGUI solution;


    private void Start()
    {
        a.text = $"{anwserA[anwserNum]}";
        b.text = $"{anwserB[anwserNum]}";
        solution.text = $"You did right {counterAnswer} answers.";
    }

    public void AnswerNum(int button)
    {
        anwserNum++;
        a.text = $"{anwserA[anwserNum]}";
        b.text = $"{anwserB[anwserNum]}";

        int randomNum = Random.Range(0, 2);
        if(randomNum == button)
        {
            counterAnswer++;
        }

        solution.text = $"You did right {counterAnswer} answers.";
    }

}
