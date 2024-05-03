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
    public TMP_Text Apple;
    public TMP_Text Chicken;
    public TMP_Text Corn;
    public TMP_Text Egg;
    public TMP_Text Lemon;
    public TMP_Text Milk;
    public TMP_Text StrawBerry;
    public TMP_Text Watermelon;

    public TMP_InputField InputFieldCow;
    public TMP_InputField InputFieldPig;
    public TMP_InputField InputFieldHorse;
    public TMP_InputField InputFieldRabbit;
    public TMP_InputField InputFieldSheep;
    public TMP_InputField InputFieldLettuce;
    public TMP_InputField InputFieldCarrot;
    public TMP_InputField InputFieldTomato;
    public TMP_InputField InputFieldOnion;
    public TMP_InputField InputFieldApple;
    public TMP_InputField InputFieldChicken;
    public TMP_InputField InputFieldCorn;
    public TMP_InputField InputFieldEgg;
    public TMP_InputField InputFieldLemon;
    public TMP_InputField InputFieldMilk;
    public TMP_InputField InputFieldStrawBerry;
    public TMP_InputField InputFieldWatermelon;

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
        if (InputFieldApple.text == "Apple" || InputFieldApple.text == "apple")
        {
            Apple.text = "Correct!";
        }
        else
        {
            Apple.text = "Incorrect!";
        }
        if (InputFieldChicken.text == "Chicken" || InputFieldChicken.text == "chicken")
        {
            Chicken.text = "Correct!";
        }
        else
        {
            Chicken.text = "Incorrect!";
        }
        if (InputFieldCorn.text == "Corn" || InputFieldCorn.text == "corn")
        {
            Corn.text = "Correct!";
        }
        else
        {
            Corn.text = "Incorrect!";
        }
        if (InputFieldEgg.text == "Egg" || InputFieldEgg.text == "egg")
        {
            Egg.text = "Correct!";
        }
        else
        {
            Egg.text = "Incorrect!";
        }
        if (InputFieldLemon.text == "Lemon" || InputFieldLemon.text == "lemon")
        {
            Lemon.text = "Correct!";
        }
        else
        {
            Lemon.text = "Incorrect!";
        }
        if (InputFieldMilk.text == "Milk" || InputFieldMilk.text == "milk")
        {
            Milk.text = "Correct!";
        }
        else
        {
            Milk.text = "Incorrect!";
        }
        if (InputFieldStrawBerry.text == "StrawBerry" || InputFieldStrawBerry.text == "strawberry")
        {
            StrawBerry.text = "Correct!";
        }
        else
        {
            StrawBerry.text = "Incorrect!";
        }
        if (InputFieldWatermelon.text == "Watermelon" || InputFieldWatermelon.text == "watermelon")
        {
            Watermelon.text = "Correct!";
        }
        else
        {
            Watermelon.text = "Incorrect!";
        }
    }
}
