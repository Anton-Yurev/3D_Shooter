using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //[SerializeField] GameObject difficultyMode;//
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        //difficultyMode.SetActive(false);//
    }
    //public void StartGame()
    //{
    //    difficultyMode.SetActive(true);//
    //    //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    //}

    //public void StartClassicGame()
    //{
    //    SceneManager.LoadScene(1);
    //}
    //public void StartSurvivalGame()
    //{
    //    SceneManager.LoadScene(2);
    //}

    //public void ExitGame()
    //{
    //    Application.Quit();//
    //}

    ////public void LoadNextLevel()
    ////{
    ////    SceneManager.LoadScene(1);
    ////}
}
