using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class LoadData : MonoBehaviour
{
    public TextMeshProUGUI name;
    public TextMeshProUGUI music;
    public TextMeshProUGUI volume;

    void Start()
    {
        // Al principio de la escena carga los players prefs en el sitio que les toque

        // Le pasa la variable "string" guardada en un player pref a un TMP
        name.text = "Tu nombre es " + PlayerPrefs.GetString("PlayerName");

        // Le pasa la variable "float" guardada en un player pref a un TMP
        volume.text = "El nivel de la musica es " + PlayerPrefs.GetFloat("volume").ToString();

        // Le pasa la variable "int/bool" guardada en un player pref a un TMP si el int es 0 devuelve false sino devuelve true
        if (PlayerPrefs.GetInt("musicOn") == 0)
        {
            music.text = "No hay musica";
        }
        else
        {
            music.text = "La musica esta activada";
        }
    }
    // Boton para volver a la escena anterior
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
