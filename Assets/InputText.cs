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
    public List<GameObject> panelsToActivate; // Lista de paneles que se activarán

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
        CheckInput(InputFieldCow, Cow, ref cow, "Cow");
        CheckInput(InputFieldPig, Pig, ref pig, "Pig");
        CheckInput(InputFieldHorse, Horse, ref horse, "Horse");
        CheckInput(InputFieldRabbit, Rabbit, ref rabbit, "Rabbit");
        CheckInput(InputFieldSheep, Sheep, ref sheep, "Sheep");
        CheckInput(InputFieldLettuce, Lettuce, ref lettuce, "Lettuce");
        CheckInput(InputFieldCarrot, Carrot, ref carrot, "Carrot");
        CheckInput(InputFieldTomato, Tomato, ref tomato, "Tomato");
        CheckInput(InputFieldOnion, Onion, ref onion, "Onion");
        CheckInput(InputFieldApple, Apple, ref apple, "Apple");
        CheckInput(InputFieldChicken, Chicken, ref chicken, "Chicken");
        CheckInput(InputFieldCorn, Corn, ref corn, "Corn");
        CheckInput(InputFieldEgg, Egg, ref egg, "Egg");
        CheckInput(InputFieldLemon, Lemon, ref lemon, "Lemon");
        CheckInput(InputFieldMilk, Milk, ref milk, "Milk");
        CheckInput(InputFieldStrawBerry, StrawBerry, ref strawberry, "StrawBerry");
        CheckInput(InputFieldWatermelon, Watermelon, ref watermelon, "Watermelon");

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
