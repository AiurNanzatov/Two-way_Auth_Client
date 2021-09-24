using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour

{
    public void LoginPassMethod()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void DigitalCodeMethod()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void BacktoMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void CAPTCHASwitcher()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void IngameInteraction()
    {
        SceneManager.LoadScene(4);
    }
}
