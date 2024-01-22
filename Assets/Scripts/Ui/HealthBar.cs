using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Image _imageHealthBar;
    [SerializeField] Image _imageHealthBarHalfAlpha;
    [SerializeField] PlayerCharacter _playerCharacter;
    [SerializeField] float _speedOfAnimations = 0.001f;

    void HealthUpdate()
    {
        _imageHealthBarHalfAlpha.fillAmount = _imageHealthBar.fillAmount;
        _imageHealthBar.fillAmount = _playerCharacter.health / _playerCharacter.healthMax;
        //_imageHealthBarHalfAlpha.fillAmount = _imageHealthBar.fillAmount;
        StartCoroutine(HealthAnimation(_speedOfAnimations));
        //_imageHealthBarHalfAlpha.fillAmount = _imageHealthBar.fillAmount;
    }
    private void OnEnable()
    {
        FirstAidKit.health += HealthUpdate;
        PlayerCharacter.receiveddamage += HealthUpdate;
    }
    private void OnDisable()
    {
        FirstAidKit.health -= HealthUpdate;
        PlayerCharacter.receiveddamage -= HealthUpdate;
    }
    public IEnumerator HealthAnimation(float _speedOfAnimations)
    {
        if (_imageHealthBarHalfAlpha.fillAmount > _imageHealthBar.fillAmount)
        {
            yield return new WaitForSeconds(_speedOfAnimations);
            _imageHealthBarHalfAlpha.fillAmount -= 0.01f;
            StartCoroutine(HealthAnimation(_speedOfAnimations));
        }
    }
}
