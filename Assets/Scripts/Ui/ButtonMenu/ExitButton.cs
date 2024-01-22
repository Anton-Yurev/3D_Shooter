using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : AbstractButton
{
    protected override void ClickOnButton()
    {
        Application.Quit();
        Debug.Log("exit");
    }
}
