using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Exercise_5 : MonoBehaviour
{
    public Sprite[] animalsSprite;
    public string[] animals;

    public TMP_InputField userYear;

    public int year;

    public int userHoroscope;

    public Image imagenAnimal;

    public TextMeshProUGUI solution;

    public GameObject questionPanel;
    public GameObject solutionPanel;

    public void ConfirmButton()
    {
        year = int.Parse(userYear.text);

        userHoroscope = year % 12;
        
        questionPanel.SetActive(false);
        solutionPanel.SetActive(true);

        solution.text = $"congatulations, your animal horoscope the {animals[userHoroscope]}";

        imagenAnimal.sprite = animalsSprite[userHoroscope];
    }
}
