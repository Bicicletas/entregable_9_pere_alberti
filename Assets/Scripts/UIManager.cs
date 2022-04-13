using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
    private string name;
    void Start()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }
    public void OptionsMenu()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }
    public void BackButton()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }
    public void Play()
    {
        print("Play");
    }
    public void Quit()
    {
        Application.Quit();
        print("Quit");
    }
    public void playerName(string s)
    {
        name = s;
        print(name);
    }
}
