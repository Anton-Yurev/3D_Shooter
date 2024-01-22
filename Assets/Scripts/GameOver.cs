using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject inscriptionAfterDeath;
    void Start()
    {
        inscriptionAfterDeath.SetActive(false);
    }
    public void DiePlayer()
    {
        inscriptionAfterDeath.SetActive(true);
        StartCoroutine(GoMainMenu());
    }
    private IEnumerator GoMainMenu()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);
    }
}
