using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class SurvivalTime : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textLifeTime;

    float seconds;
    float minuts;
    float hours;
    void Update()
    {
        Timer();
    }
    void Timer()
    {
        seconds += Time.deltaTime;
        if (seconds >= 60)
        {
            minuts++;
            seconds = 0;
            if (minuts >= 60)
            {
                hours++;
                minuts = 0;
            }
        }
        _textLifeTime.text = ($"{Mathf.Round(hours)}h;{Mathf.Round(minuts)}m;{Mathf.Round(seconds)}s").ToString();
        //UnityEngine.Debug.Log($"hours= {Mathf.Round(hours)}; min= {Mathf.Round(minuts)}; sec= {Mathf.Round(seconds)}");
    }
}
