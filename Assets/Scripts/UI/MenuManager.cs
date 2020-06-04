using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [Header("UI")]
    public GameObject OptionsUI;
    public GameObject MenuUI;


    //Launch the game
    public void Play()
    {
        SceneManager.LoadScene("HUB");
    }

    //Display the options
    public void Options()
    {
        MenuUI.SetActive(false);
        OptionsUI.SetActive(true);
    }

    //Hidding the options
    public void Back()
    {
        MenuUI.SetActive(true);
        OptionsUI.SetActive(false);
    }

    ////Change the volume through the value of the volume slider
    //public void SetVolume(float volume)
    //{
    //    Debug.Log(volume);
    //}

    //Quit the game
    public void Quit()
    {
        Debug.Log("Quitting application...");
        Application.Quit();
    }
}
