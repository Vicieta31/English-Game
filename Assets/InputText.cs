using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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

    public GameObject textToActivate;
    public GameObject buttonToActivate;
    public GameObject buttonCheck;

    private bool cow;
    private bool pig;
    private bool horse;
    private bool rabbit;
    private bool sheep;
    private bool lettuce;
    private bool carrot;
    private bool tomato;
    private bool onion;
    private bool apple;
    private bool chicken;
    private bool corn;
    private bool egg;
    private bool lemon;
    private bool milk;
    private bool strawberry;
    private bool watermelon;

    // Start is called before the first frame update
    void Start()
    {
        cow = false;
        pig = false;
        horse = false;
        rabbit = false;
        sheep = false;
        lettuce = false;
        carrot = false;
        tomato = false;
        onion = false;
        apple = false;
        chicken = false;
        corn = false;
        egg = false;
        lemon = false;
        milk = false;
        strawberry = false;
        watermelon = false;

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
        if (InputFieldCow.text == "Cow" || InputFieldCow.text == "cow")
        {
            Cow.text = "Correct!";
            cow = true;
        }
        else
        {
            Cow.text = "Incorrect!";
            cow = false;
        }
        if (InputFieldPig.text == "Pig" || InputFieldPig.text == "pig")
        {
            Pig.text = "Correct!";
            pig = true;
        }
        else
        {
           Pig.text = "Incorrect!";
           pig = false;
        }
        if (InputFieldHorse.text == "Horse" || InputFieldHorse.text == "horse")
        {
            Horse.text = "Correct!";
            horse = true;
        }
        else
        {
            Horse.text = "Incorrect!";
            horse = false;
        }
        if (InputFieldRabbit.text == "Rabbit" || InputFieldRabbit.text == "rabbit")
        {
            Rabbit.text = "Correct!";
            rabbit = true;
        }
        else
        {
            Rabbit.text = "Incorrect!";
            rabbit = false;
        }
        if (InputFieldSheep.text == "Sheep" || InputFieldSheep.text == "sheep")
        {
            Sheep.text = "Correct!";
            sheep = true;
        }
        else
        {
            Sheep.text = "Incorrect!";
            sheep = false;
        }
        if (InputFieldLettuce.text == "Lettuce" || InputFieldLettuce.text == "lettuce")
        {
            Lettuce.text = "Correct!";
            lettuce = true;
        }
        else
        {
            Lettuce.text = "Incorrect!";
            lettuce = false;
        }
        if (InputFieldCarrot.text == "Carrot" || InputFieldCarrot.text == "carrot")
        {
            Carrot.text = "Correct!";
            carrot = true;
        }
        else
        {
            Carrot.text = "Incorrect!";
            carrot = false;
        }
        if (InputFieldTomato.text == "Tomato" || InputFieldTomato.text == "tomato")
        {
            Tomato.text = "Correct!";
            tomato = true;
        }
        else
        {
            Tomato.text = "Incorrect!";
            tomato = false;
        }
        if (InputFieldOnion.text == "Onion" || InputFieldOnion.text == "onion")
        {
            Onion.text = "Correct!";
            onion = true;
        }
        else
        {
            Onion.text = "Incorrect!";
            onion = false;
        }
        if (InputFieldApple.text == "Apple" || InputFieldApple.text == "apple")
        {
            Apple.text = "Correct!";
            apple = true;
        }
        else
        {
            Apple.text = "Incorrect!";
            apple = false;
        }
        if (InputFieldChicken.text == "Chicken" || InputFieldChicken.text == "chicken")
        {
            Chicken.text = "Correct!";
            chicken = true;
        }
        else
        {
            Chicken.text = "Incorrect!";
            chicken = false;
        }
        if (InputFieldCorn.text == "Corn" || InputFieldCorn.text == "corn")
        {
            Corn.text = "Correct!";
            corn = true;
        }
        else
        {
            Corn.text = "Incorrect!";
            corn = false;
        }
        if (InputFieldEgg.text == "Egg" || InputFieldEgg.text == "egg")
        {
            Egg.text = "Correct!";
            egg = true;
        }
        else
        {
            Egg.text = "Incorrect!";
            egg = false;
        }
        if (InputFieldLemon.text == "Lemon" || InputFieldLemon.text == "lemon")
        {
            Lemon.text = "Correct!";
            lemon = true;
        }
        else
        {
            Lemon.text = "Incorrect!";
            lemon = false;
        }
        if (InputFieldMilk.text == "Milk" || InputFieldMilk.text == "milk")
        {
            Milk.text = "Correct!";
            milk = true;
        }
        else
        {
            Milk.text = "Incorrect!";
            milk = false;
        }
        if (InputFieldStrawBerry.text == "StrawBerry" || InputFieldStrawBerry.text == "strawberry")
        {
            StrawBerry.text = "Correct!";
            strawberry = true;
        }
        else
        {
            StrawBerry.text = "Incorrect!";
            strawberry = false;
        }
        if (InputFieldWatermelon.text == "Watermelon" || InputFieldWatermelon.text == "watermelon")
        {
            Watermelon.text = "Correct!";
            watermelon = true;
        }
        else
        {
            Watermelon.text = "Incorrect!";
            watermelon = false;
        }

        if (cow && pig && horse && rabbit && sheep && lettuce && carrot && tomato && onion && apple && chicken && corn && egg && lemon && milk && strawberry && watermelon)
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
