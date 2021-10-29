using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour

{
    public void LoginPassMethod()
    {
        SceneManager.LoadScene(0);
    }

    public void BacktoMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void DigitalCodeMethod()
    {
        SceneManager.LoadScene(2);
    }

    public void CAPTCHASwitcher()
    {
        SceneManager.LoadScene(3);
    }

    public void SoundUsage()
    {
        SceneManager.LoadScene(4);
    }

    public void IngameInteraction()
    {
        SceneManager.LoadScene(5);
    }

    public void ClosePopUp()
    {
        SceneManager.LoadPreviousScene();
    }
}
