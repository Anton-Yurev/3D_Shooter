using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    [SerializeField] ZombieSpawn zombieSpawn;
    [SerializeField] ScoreKill scoreKill;
    [SerializeField] GameObject winZone;
    int _numberZombieInLevel;

    void Start()
    {
        winZone.SetActive(false);
        _numberZombieInLevel = zombieSpawn.NumberOfZombies + 1;
    }

    void Update()
    {
        if (_numberZombieInLevel == scoreKill.KillPoint)
        {
            ActivateWinZone();
        }
    }

    void ActivateWinZone()
    {
        winZone.SetActive(true);
    }
}
