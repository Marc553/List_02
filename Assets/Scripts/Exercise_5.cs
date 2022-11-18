using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Exercise_5 : MonoBehaviour
{
    public Sprite[] animalsSprite;//array that save all the sprites
    public string[] animals;//array that save all the animals names

    public TMP_InputField userYear;//varaible that gets the year put in the input field

    public int year;//save the year of the input field

    public int userHoroscope;//the animal which you are

    public Image imagenAnimal;//where the sprite will be showed

    public TextMeshProUGUI solution;//shows what animal you are

    public GameObject questionPanel;//where is the input field, the confirm button and the question 
    public GameObject solutionPanel;//where is sprite and the solution text

    public void ConfirmButton()//function taht do all the loginc of the script when the button is pressed
    {
        year = int.Parse(userYear.text);//gets the number written in the input field

        userHoroscope = year % 12;//calculate the animal that you are getting the residue of the division of your birth year and 12(the animals that there are)

        questionPanel.SetActive(false);//sets off the question panel 
        solutionPanel.SetActive(true);//sets on the solution panel

        solution.text = $"congatulations, your animal horoscope the {animals[userHoroscope]}";//shows the solution of your year

        imagenAnimal.sprite = animalsSprite[userHoroscope];//sets the sprite in the image varaible 
    }
}
