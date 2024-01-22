using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : AbstractButton
{
    [SerializeField] GameObject _windowOfClose;
    protected override void ClickOnButton()
    {
        _windowOfClose.SetActive(false);
    }
}
