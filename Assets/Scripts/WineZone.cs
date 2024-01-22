using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WineZone : MonoBehaviour
{
    [SerializeField] GameObject WinText;
    private void Awake()
    {
        WinText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        WinText.SetActive(true);
        StartCoroutine(GoMainMenu());
    }
    
    private IEnumerator GoMainMenu()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);
    }


}
