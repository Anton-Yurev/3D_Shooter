using System;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static Action OnPauseOn = delegate { };
    public static Action OnPauseOff = delegate { };
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0.0f;
                OnPauseOn();
            }
            else
            {
                Time.timeScale = 1.0f;
                OnPauseOff();
            }

        }
    }
}
