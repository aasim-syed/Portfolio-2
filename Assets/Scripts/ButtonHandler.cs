using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public GameObject startText;

    public void CarFun()
    {
        Application.OpenURL("https://github.com/pranshi112/CarFun");
    }
    public void TimesUp()
    {
        Application.OpenURL("https://github.com/pranshi112/Time-s-Up");
    }
    public void RollerMadness()
    {
        Application.OpenURL("https://github.com/pranshi112/RollerMadness");
    }
    public void HealthyShibo()
    {
        Application.OpenURL("https://github.com/pranshi112/HealthyShibo");
    }
    public void PlaceMyFood()
    {
        Application.OpenURL("https://github.com/pranshi112/PlaceMyFood");
    }
    public void HackerRank()
    {
        Application.OpenURL("https://www.hackerrank.com/apranshi11?hr_r=1");
    }
    public void MainScene()
    {
        startText.SetActive(true);
        SceneManager.LoadSceneAsync("MainScene");
    }
    public void ReturnHome()
    {
        SceneManager.UnloadSceneAsync("About");
    }
    public void ReturnSchool()
    {
        SceneManager.UnloadSceneAsync("Education");
    }
    public void ReturnAchievements()
    {
        SceneManager.UnloadSceneAsync("Achievements");
    }
    public void ReturnSkills()
    {
        SceneManager.UnloadSceneAsync("Skills");
    }
    public void ReturnProjects()
    {
        SceneManager.UnloadSceneAsync("Projects");
    }
    public void ReturnOffice()
    {
        SceneManager.UnloadSceneAsync("Experience");
    }
}
