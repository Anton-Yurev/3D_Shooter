using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class PlayerCharacter : MonoBehaviour,IReactionOnDamage
{
    public static Action receiveddamage;

    [SerializeField] GameOver _gameOver;

    [SerializeField] float _health;
    public float health => this._health;

    [SerializeField] int _healthMax = 100;
    public float healthMax => this._healthMax;
    void Start()
    {
        _health = _healthMax;
    }

    public void Health(int health)
    {
        _health += health;
        if (_health > _healthMax)
        {
            _health = _healthMax;
        }
    }

    public void ReactionOnDamage(int damage)
    {
        _health -= damage;
        receiveddamage?.Invoke();
        if (_health <= 0)
        {
            _gameOver.DiePlayer();
        }
    }
}
