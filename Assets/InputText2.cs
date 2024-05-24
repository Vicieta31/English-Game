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
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonPressed()
    {
        if (InputField_Hot_Air_Baloon.text == "Hot Air Baloon" || InputField_Hot_Air_Baloon.text == "hot air baloon")
        {
            Hot_Air_Baloon.text = "Correct!";
            one = true;
        }
        else
        {
            Hot_Air_Baloon.text = "Incorrect!";
            one = false;
        }

        if (InputField_Plane.text == "Plane" || InputField_Plane.text == "plane")
        {
            Plane.text = "Correct!";
            two = true;
        }
        else
        {
            Plane.text = "Incorrect!";
            two = false;
        }

        if (InputField_Car.text == "Car" || InputField_Car.text == "car")
        {
            Car.text = "Correct!";
            three = true;
        }
        else
        {
            Car.text = "Incorrect!";
            three = false;
        }

        if (InputField_Sailboat.text == "Sailboat" || InputField_Sailboat.text == "sailboat")
        {
            Sailboat.text = "Correct!";
            four = true;
        }
        else
        {
            Sailboat.text = "Incorrect!";
            four = false;
        }

        if (InputField_Motorcycle.text == "Motorcycle" || InputField_Motorcycle.text == "motorcycle")
        {
            Motorcycle.text = "Correct!";
            five = true;
        }
        else
        {
            Motorcycle.text = "Incorrect!";
            five = false;
        }

        if (InputField_Ship.text == "Ship" || InputField_Ship.text == "ship")
        {
            Ship.text = "Correct!";
            six = true;
        }
        else
        {
            Ship.text = "Incorrect!";
            six = false;
        }

        if (InputField_Taxi.text == "Taxi" || InputField_Taxi.text == "taxi")
        {
            Taxi.text = "Correct!";
            seven = true;
        }
        else
        {
            Taxi.text = "Incorrect!";
            seven = false;
        }

        if (InputField_Train.text == "Train" || InputField_Train.text == "train")
        {
            Train.text = "Correct!";
            eight = true;
        }
        else
        {
            Train.text = "Incorrect!";
            eight = false;
        }

        if (InputField_Dog.text == "Dog" || InputField_Dog.text == "dog")
        {
            Dog.text = "Correct!";
            nine = true;
        }
        else
        {
            Dog.text = "Incorrect!";
            nine = false;
        }

        if (InputField_Cat.text == "Cat" || InputField_Cat.text == "cat")
        {
            Cat.text = "Correct!";
            ten = true;
        }
        else
        {
            Cat.text = "Incorrect!";
            ten = false;
        }

        if (InputField_Bird.text == "Bird" || InputField_Bird.text == "bird")
        {
            Bird.text = "Correct!";
            eleven = true;
        }
        else
        {
            Bird.text = "Incorrect!";
            eleven = false;
        }

        if (InputField_Squirrel.text == "Squirrel" || InputField_Squirrel.text == "squirrel")
        {
            Squirrel.text = "Correct!";
            twelve = true;
        }
        else
        {
            Squirrel.text = "Incorrect!";
            twelve = false;
        }

        if (InputField_Mouse.text == "Mouse" || InputField_Mouse.text == "mouse")
        {
            Mouse.text = "Correct!";
            thirdteen = true;
        }
        else
        {
            Mouse.text = "Incorrect!";
            thirdteen = false;
        }

        if (InputField_Pigeon.text == "Pigeon" || InputField_Pigeon.text == "pigeon")
        {
            Pigeon.text = "Correct!";
            fourteen = true;
        }
        else
        {
            Pigeon.text = "Incorrect!";
            fourteen = false;
        }

        if (InputField_Bread.text == "Bread" || InputField_Bread.text == "bread")
        {
            Bread.text = "Correct!";
            fiveteen = true;
        }
        else
        {
            Bread.text = "Incorrect!";
            fiveteen = false;
        }

        if (InputField_Ice_Cream.text == "Ice Cream" || InputField_Ice_Cream.text == "ice cream")
        {
            Ice_Cream.text = "Correct!";
            sixteen = true;
        }
        else
        {
            Ice_Cream.text = "Incorrect!";
            sixteen = false;
        }

        if (InputField_Hamburger.text == "Hamburger" || InputField_Hamburger.text == "hamburger")
        {
            Hamburger.text = "Correct!";
            seventeen = true;
        }
        else
        {
            Hamburger.text = "Incorrect!";
            seventeen = false;
        }


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

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
