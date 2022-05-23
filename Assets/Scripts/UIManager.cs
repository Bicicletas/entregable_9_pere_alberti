using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;

    private string name;
    private int trueFalse;

    public TMP_InputField nombre;
    public Toggle volumeToggle;
    public Slider volume;

    void Start()
    {
        // Confirmar que siempre empiece la escena como toca
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);

        // Cargar los player prefs al volver al menu de inicio y al salir del juego
        nombre.text = PlayerPrefs.GetString("PlayerName");
        trueFalse = PlayerPrefs.GetInt("musicOn");
        volume.value = PlayerPrefs.GetFloat("volume");
        volumeToggle.isOn = IntToBool(trueFalse);

    }
    // Boton del menu de opciones
    public void OptionsMenu()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }
    // Boton del menu de volver al menu principal
    public void BackButton()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }
    // Boton para empezar el juego
    public void Play()
    {
        SceneManager.LoadScene(1);
        SaveData();
    }
    // Boton para salir del juego
    public void Quit()
    {
        Application.Quit();
        print("Quit");
    }
    // Funcion de un Input field que guarda un string
    public void playerName(string s)
    {
        name = s;
    }
    // Funcion que guarda los datos que se quieren guardar en los players prefs
    public void SaveData()
    {
        trueFalse = BoolToInt(volumeToggle.isOn);
        // Guardar un string
        PlayerPrefs.SetString("PlayerName", nombre.text);
        // Guardar un int/bool
        PlayerPrefs.SetInt("musicOn", trueFalse);
        // Guardar un float
        PlayerPrefs.SetFloat("volume", volume.value);
    }
    // Convertir un int a bool
    private bool IntToBool(int i)
    {
        // Si el int es 0 devuelve false sino devuelve true
        if (i == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    // Convertir un bool a int
    private int BoolToInt(bool b)
    {
        // Si el bool es true devuelve 1 sino devuelve 0
        if (b)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
