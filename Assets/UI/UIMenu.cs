using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
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
}
