using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public void ClickOnCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void ClickOnPlay()
    {
        SceneManager.LoadScene("Game");
    }
    public void ClickOnQuit()
    {
        Application.Quit();
    }
    public void ClickOnMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
