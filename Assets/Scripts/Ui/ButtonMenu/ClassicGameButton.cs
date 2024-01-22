using UnityEngine.SceneManagement;

public class ClassicGameButton : AbstractButton
{
    protected override void ClickOnButton()
    {
        SceneManager.LoadScene(1);
    }
}
