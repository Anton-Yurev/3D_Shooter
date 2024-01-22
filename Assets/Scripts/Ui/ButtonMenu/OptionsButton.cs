using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsButton : AbstractButton
{
    [SerializeField] private GameObject _optionsMenu;
    private void Awake()
    {
        _optionsMenu.SetActive(false);
    }
    protected override void ClickOnButton()
    {
        _optionsMenu.SetActive(true);
    }
    
}
