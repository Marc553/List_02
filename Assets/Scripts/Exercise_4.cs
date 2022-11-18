
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Exercise_4 : MonoBehaviour
{
    public string[] anwserA;//array with the anwsers A
    public string[] anwserB;//array with the anwsers B

    public int anwserNum = 0;//sets the number of the question
    public int counterAnswer = 0;//checks how many answers are well

    public TextMeshProUGUI a;//put the next option a
    public TextMeshProUGUI b;//put the next option b
    public TextMeshProUGUI solution;//shows the solution


    private void Start()
    {
        a.text = $"{anwserA[anwserNum]}";//shows the first question
        b.text = $"{anwserB[anwserNum]}";//shows the first question
        solution.text = $"You did right {counterAnswer} answers.";//shows how many answers are well
    }

    public void AnswerNum(int button)//change the nomber of the question when the button is pressed
    {
        anwserNum++;//pass to the next number
        a.text = $"{anwserA[anwserNum]}";//shows the next question 
        b.text = $"{anwserB[anwserNum]}";//shows the next question 

        int randomNum = Random.Range(0, 2);//choose one of the two options(a,b)
        if(randomNum == button)//when the person choose the same number of the random number plus one point to the variable cunter answer
        {
            counterAnswer++;//plus one point 
        }

        solution.text = $"You did right {counterAnswer} answers.";//shows the number of correct solutions  
    }

}
