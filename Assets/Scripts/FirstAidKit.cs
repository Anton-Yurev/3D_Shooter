using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAidKit : MonoBehaviour
{
    public static Action health;
    PlayerCharacter _playerCharacter;
    [SerializeField] int _health = 25;
    private void OnTriggerEnter(Collider other)
    {
        _playerCharacter = other.GetComponent<PlayerCharacter>();
        if (_playerCharacter.health < _playerCharacter.healthMax)
        {
            _playerCharacter.Health(_health);
            health?.Invoke();
            Destroy(this.gameObject);
        }
    }
}
