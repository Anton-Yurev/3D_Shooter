using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SurvivalGameButton : AbstractButton
{
    protected override void ClickOnButton()
    {
        SceneManager.LoadScene(2);
    }
}
