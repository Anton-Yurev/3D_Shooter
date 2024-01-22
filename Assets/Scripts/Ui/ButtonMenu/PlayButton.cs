using UnityEngine;

public class PlayButton : AbstractButton
{
    [SerializeField] GameObject difficultyMode;
    private void Awake()
    {
        difficultyMode.SetActive(false);
    }
    protected override void ClickOnButton()
    {
        Debug.Log("go");
        difficultyMode.SetActive(true);
    }
}
