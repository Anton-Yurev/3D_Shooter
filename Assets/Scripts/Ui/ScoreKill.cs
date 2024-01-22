using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreKill : MonoBehaviour
{
    [SerializeField] ZombieSpawn zombieSpawn;
    [SerializeField] TextMeshProUGUI textkillPoint;
    [SerializeField] TextMeshProUGUI textNumberZombieInLevel;
    int _killPoint = 0;
    public int KillPoint=>this._killPoint;
    void Start()
    {
        textkillPoint.text = _killPoint.ToString();
        textNumberZombieInLevel.text= "/"+(zombieSpawn.NumberOfZombies+1).ToString();
    }
    public void AddKillPoint()
    {
        _killPoint++;
        textkillPoint.text=_killPoint.ToString();
    }
    private void OnEnable()
    {
        Zombie.ZombieIsDead += AddKillPoint;
    }
    private void OnDisable()
    {
        Zombie.ZombieIsDead -= AddKillPoint;
    }
}
