using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputText : MonoBehaviour
{
    public TMP_Text Cow;
    public TMP_Text Pig;
    public TMP_Text Horse;
    public TMP_Text Rabbit;
    public TMP_Text Sheep;
    public TMP_Text Lettuce;
    public TMP_Text Carrot;
    public TMP_Text Tomato;
    public TMP_Text Onion;

    public TMP_InputField InputFieldCow;
    public TMP_InputField InputFieldPig;
    public TMP_InputField InputFieldHorse;
    public TMP_InputField InputFieldRabbit;
    public TMP_InputField InputFieldSheep;
    public TMP_InputField InputFieldLettuce;
    public TMP_InputField InputFieldCarrot;
    public TMP_InputField InputFieldTomato;
    public TMP_InputField InputFieldOnion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPressed()
    {
        if (InputFieldCow.text == "Cow" || InputFieldCow.text == "cow")
        {
            Cow.text = "Correct!";
        }
        else
        {
            Cow.text = "Incorrect!";
        }
        if (InputFieldPig.text == "Pig" || InputFieldPig.text == "pig")
        {
            Pig.text = "Correct!";
        }
        else
        {
           Pig.text = "Incorrect!";
        }
        if (InputFieldHorse.text == "Horse" || InputFieldHorse.text == "horse")
        {
            Horse.text = "Correct!";
        }
        else
        {
            Horse.text = "Incorrect!";
        }
        if (InputFieldRabbit.text == "Rabbit" || InputFieldRabbit.text == "rabbit")
        {
            Rabbit.text = "Correct!";
        }
        else
        {
            Rabbit.text = "Incorrect!";
        }
        if (InputFieldSheep.text == "Sheep" || InputFieldSheep.text == "sheep")
        {
            Sheep.text = "Correct!";
        }
        else
        {
            Sheep.text = "Incorrect!";
        }
        if (InputFieldLettuce.text == "Lettuce" || InputFieldLettuce.text == "lettuce")
        {
            Lettuce.text = "Correct!";
        }
        else
        {
            Lettuce.text = "Incorrect!";
        }
        if (InputFieldCarrot.text == "Carrot" || InputFieldCarrot.text == "carrot")
        {
            Carrot.text = "Correct!";
        }
        else
        {
            Carrot.text = "Incorrect!";
        }
        if (InputFieldTomato.text == "Tomato" || InputFieldTomato.text == "tomato")
        {
            Tomato.text = "Correct!";
        }
        else
        {
            Tomato.text = "Incorrect!";
        }
        if (InputFieldOnion.text == "Onion" || InputFieldOnion.text == "onion")
        {
            Onion.text = "Correct!";
        }
        else
        {
            Onion.text = "Incorrect!";
        }
    }
}
