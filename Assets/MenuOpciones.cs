using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MenuOpciones : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    public void PantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }

    public void Volumen(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }
    public void CalidadGrafica(int calidadIndex)
    {
        QualitySettings.SetQualityLevel(calidadIndex);
    }
    public void SalirMenuPrincipal()
    {
        SceneManager.LoadScene("Menu Principal");
    }
}
