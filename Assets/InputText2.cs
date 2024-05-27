using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InputText2 : MonoBehaviour
{
    public TMP_Text Hot_Air_Baloon;
    public TMP_Text Plane;
    public TMP_Text Car;
    public TMP_Text Sailboat;
    public TMP_Text Motorcycle;
    public TMP_Text Ship;
    public TMP_Text Taxi;
    public TMP_Text Train;
    public TMP_Text Dog;
    public TMP_Text Cat;
    public TMP_Text Bird;
    public TMP_Text Squirrel;
    public TMP_Text Mouse;
    public TMP_Text Pigeon;
    public TMP_Text Bread;
    public TMP_Text Ice_Cream;
    public TMP_Text Hamburger;

    public TMP_InputField InputField_Hot_Air_Baloon;
    public TMP_InputField InputField_Plane;
    public TMP_InputField InputField_Car;
    public TMP_InputField InputField_Sailboat;
    public TMP_InputField InputField_Motorcycle;
    public TMP_InputField InputField_Ship;
    public TMP_InputField InputField_Taxi;
    public TMP_InputField InputField_Train;
    public TMP_InputField InputField_Dog;
    public TMP_InputField InputField_Cat;
    public TMP_InputField InputField_Bird;
    public TMP_InputField InputField_Squirrel;
    public TMP_InputField InputField_Mouse;
    public TMP_InputField InputField_Pigeon;
    public TMP_InputField InputField_Bread;
    public TMP_InputField InputField_Ice_Cream;
    public TMP_InputField InputField_Hamburger;

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
    private bool thirdteen;
    private bool fourteen;
    private bool fiveteen;
    private bool sixteen;
    private bool seventeen;

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
        thirdteen = false;
        fourteen = false;
        fiveteen = false;
        sixteen = false;
        seventeen = false;

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
        CheckInput(InputField_Hot_Air_Baloon, Hot_Air_Baloon, ref one, "Hot Air Baloon");
        CheckInput(InputField_Plane, Plane, ref two, "Plane");
        CheckInput(InputField_Car, Car, ref three, "Car");
        CheckInput(InputField_Sailboat, Sailboat, ref four, "Sailboat");
        CheckInput(InputField_Motorcycle, Motorcycle, ref five, "Motorcycle");
        CheckInput(InputField_Ship, Ship, ref six, "Ship");
        CheckInput(InputField_Taxi, Taxi, ref seven, "Taxi");
        CheckInput(InputField_Train, Train, ref eight, "Train");
        CheckInput(InputField_Dog, Dog, ref nine, "Dog");
        CheckInput(InputField_Cat, Cat, ref ten, "Cat");
        CheckInput(InputField_Bird, Bird, ref eleven, "Bird");
        CheckInput(InputField_Squirrel, Squirrel, ref twelve, "Squirrel");
        CheckInput(InputField_Mouse, Mouse, ref thirdteen, "Mouse");
        CheckInput(InputField_Pigeon, Pigeon, ref fourteen, "Pigeon");
        CheckInput(InputField_Bread, Bread, ref fiveteen, "Bread");
        CheckInput(InputField_Ice_Cream, Ice_Cream, ref sixteen, "Ice Cream");
        CheckInput(InputField_Hamburger, Hamburger, ref seventeen, "Hamburger");

        if (one && two && three && four && five && six && seven && eight && nine && ten && eleven && twelve && thirdteen && fourteen && fiveteen && sixteen && seventeen)
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
