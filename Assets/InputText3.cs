using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InputText3 : MonoBehaviour
{
    public TMP_Text Cocodrile;
    public TMP_Text Elephant;
    public TMP_Text Giraffe;
    public TMP_Text Hippopotamus;
    public TMP_Text Koala;
    public TMP_Text Lion;
    public TMP_Text Monkey;
    public TMP_Text Ostrich;
    public TMP_Text Panda;
    public TMP_Text Tiger;
    public TMP_Text Turtle;
    public TMP_Text Zebra;

    public TMP_InputField InputField_Cocodrile;
    public TMP_InputField InputField_Elephant;
    public TMP_InputField InputField_Giraffe;
    public TMP_InputField InputField_Hippopotamus;
    public TMP_InputField InputField_Koala;
    public TMP_InputField InputField_Lion;
    public TMP_InputField InputField_Monkey;
    public TMP_InputField InputField_Ostrich;
    public TMP_InputField InputField_Panda;
    public TMP_InputField InputField_Tiger;
    public TMP_InputField InputField_Turtle;
    public TMP_InputField InputField_Zebra;

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
    private bool eleven;
    private bool twelve;

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
        eleven = false;
        twelve = false;

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
        CheckInput(InputField_Cocodrile, Cocodrile, ref one, "Cocodrile");
        CheckInput(InputField_Elephant, Elephant, ref two, "Elephant");
        CheckInput(InputField_Giraffe, Giraffe, ref three, "Giraffe");
        CheckInput(InputField_Hippopotamus, Hippopotamus, ref four, "Hippopotamus");
        CheckInput(InputField_Koala, Koala, ref five, "Koala");
        CheckInput(InputField_Lion, Lion, ref six, "Lion");
        CheckInput(InputField_Monkey, Monkey, ref seven, "Monkey");
        CheckInput(InputField_Ostrich, Ostrich, ref eight, "Ostrich");
        CheckInput(InputField_Panda, Panda, ref nine, "Panda");
        CheckInput(InputField_Tiger, Tiger, ref ten, "Tiger");
        CheckInput(InputField_Turtle, Turtle, ref eleven, "Turtle");
        CheckInput(InputField_Zebra, Zebra, ref twelve, "Zebra");

        if (one && two && three && four && five && six && seven && eight && nine && ten && eleven && twelve)
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
