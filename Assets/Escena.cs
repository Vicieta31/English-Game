using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        SceneManager.LoadScene("Level1");
    }
    public void opciones()
    {
        SceneManager.LoadScene("Menu Options");
    }
    public void resume()
    {
        
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu Principal");
    }

    public void salir()
    {
        Application.Quit();
    }
}
