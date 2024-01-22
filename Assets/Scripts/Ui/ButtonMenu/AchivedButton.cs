using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchivedButton : AbstractButton
{
    [SerializeField] GameObject AchivedMenu;
    protected override void ClickOnButton()
    {
        AchivedMenu.SetActive(true);

    }
}
