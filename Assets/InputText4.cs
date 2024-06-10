using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InputText4 : MonoBehaviour
{
    public TMP_Text Jellyfish;
    public TMP_Text Starfish;
    public TMP_Text Octopus;
    public TMP_Text Lobster;
    public TMP_Text Seahorse;
    public TMP_Text Submarine;
    public TMP_Text Seaplane;
    public TMP_Text Coconut;
    public TMP_Text Pineapple;
    public TMP_Text Mango;

    public TMP_InputField InputField_Jellyfish;
    public TMP_InputField InputField_Starfish;
    public TMP_InputField InputField_Octopus;
    public TMP_InputField InputField_Lobster;
    public TMP_InputField InputField_Seahorse;
    public TMP_InputField InputField_Submarine;
    public TMP_InputField InputField_Seaplane;
    public TMP_InputField InputField_Coconut;
    public TMP_InputField InputField_Pineapple;
    public TMP_InputField InputField_Mango;

    public List<GameObject> panelsToActivate;

    public GameObject textToActivate;
    public GameObject buttonToActivate;
    public GameObject buttonCheck;

    private bool one;
    private bool two;
    private bool three;
    private bool four;
    private bool five;
    private bool six;
    private bool seven;
    private bool eight;
    private bool nine;
    private bool ten;

    // Start is called before the first frame update
    void Start()
    {
        one = false;
        two = false;
        three = false;
        four = false;
        five = false;
        six = false;
        seven = false;
        eight = false;
        nine = false;
        ten = false;

        textToActivate.SetActive(false);
        buttonToActivate.SetActive(false);
        buttonCheck.SetActive(true);

        foreach (var panel in panelsToActivate)
        {
            panel.SetActive(false); // Asegúrate de que los paneles estén desactivados al inicio
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonPressed()
    {
        CheckInput(InputField_Jellyfish, Jellyfish, ref one, "Jellyfish");
        CheckInput(InputField_Starfish, Starfish, ref two, "Starfish");
        CheckInput(InputField_Octopus, Octopus, ref three, "Octopus");
        CheckInput(InputField_Lobster, Lobster, ref four, "Lobster");
        CheckInput(InputField_Seahorse, Seahorse, ref five, "Seahorse");
        CheckInput(InputField_Submarine, Submarine, ref six, "Submarine");
        CheckInput(InputField_Seaplane, Seaplane, ref seven, "Seaplane");
        CheckInput(InputField_Coconut, Coconut, ref eight, "Coconut");
        CheckInput(InputField_Pineapple, Pineapple, ref nine, "Pineapple");
        CheckInput(InputField_Mango, Mango, ref ten, "Mango");

        if (one && two && three && four && five && six && seven && eight && nine && ten)
        {
            textToActivate.SetActive(true);
            buttonToActivate.SetActive(true);
            buttonCheck.SetActive(false);
            
        }
        else
        {
            textToActivate.SetActive(false);
            buttonToActivate.SetActive(false);
            buttonCheck.SetActive(true);
        }
    }

    private void CheckInput(TMP_InputField inputField, TMP_Text outputText, ref bool flag, string correctText)
    {
        if (inputField.text.ToLower() == correctText.ToLower())
        {
            outputText.text = "Correct!";
            outputText.color = Color.green;
            flag = true;
        }
        else
        {
            outputText.text = "Incorrect!";
            outputText.color = Color.red;
            flag = false;
        }

        foreach (var panel in panelsToActivate)
        {
            panel.SetActive(true); // Asegúrate de que los paneles estén desactivados al inicio
        }
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
