using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InputText5 : MonoBehaviour
{
    public TMP_Text Bear;
    public TMP_Text Eagle;
    public TMP_Text Deer;
    public TMP_Text Fox;
    public TMP_Text Marmot;
    public TMP_Text Cable_car;
    public TMP_Text Sled;
    public TMP_Text Snowmobile;
    public TMP_Text Raspberry;
    public TMP_Text Honey;
    public TMP_Text Cheese;

    public TMP_InputField InputField_Bear;
    public TMP_InputField InputField_Eagle;
    public TMP_InputField InputField_Deer;
    public TMP_InputField InputField_Fox;
    public TMP_InputField InputField_Marmot;
    public TMP_InputField InputField_Cable_car;
    public TMP_InputField InputField_Sled;
    public TMP_InputField InputField_Snowmobile;
    public TMP_InputField InputField_Raspberry;
    public TMP_InputField InputField_Honey;
    public TMP_InputField InputField_Cheese;

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
        CheckInput(InputField_Bear, Bear, ref one, "Bear");
        CheckInput(InputField_Eagle, Eagle, ref two, "Eagle");
        CheckInput(InputField_Deer, Deer, ref three, "Deer");
        CheckInput(InputField_Fox, Fox, ref four, "Fox");
        CheckInput(InputField_Marmot, Marmot, ref five, "Marmot");
        CheckInput(InputField_Cable_car, Cable_car, ref six, "Cable car");
        CheckInput(InputField_Sled, Sled, ref seven, "Sled");
        CheckInput(InputField_Snowmobile, Snowmobile, ref eight, "Snowmobile");
        CheckInput(InputField_Raspberry, Raspberry, ref nine, "Raspberry");
        CheckInput(InputField_Honey, Honey, ref ten, "Honey");
        CheckInput(InputField_Cheese, Cheese, ref eleven, "Cheese");

        if (one && two && three && four && five && six && seven && eight && nine && ten && eleven)
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
