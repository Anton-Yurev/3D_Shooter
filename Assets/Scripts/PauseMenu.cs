using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    private void OnEnable()
    {
        Pause.OnPauseOn += OpenPauseMenu;
        Pause.OnPauseOff += ClosePauseMenu;
    }

    private void OnDisable()
    {
        Pause.OnPauseOn -= OpenPauseMenu;
        Pause.OnPauseOff -= ClosePauseMenu;
    }

    private void OpenPauseMenu()
    {
        _pauseMenu.SetActive(true);
    }
    private void ClosePauseMenu()
    {
        _pauseMenu.SetActive(false);
    }
}
