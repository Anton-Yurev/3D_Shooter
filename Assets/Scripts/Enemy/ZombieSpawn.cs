using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawn : MonoBehaviour
{
    [SerializeField] GameObject _zombiePrefab;
    [SerializeField] Transform[] pointSpavn = new Transform[numberOfPointsSpawn];
    [SerializeField] float delaySpawn = 4;
    [SerializeField] int _numberOfZombies=29;
    public int NumberOfZombies => this._numberOfZombies;
    static int numberOfPointsSpawn = 3;

    float timer;
    private void Start()
    {
        StartCoroutine(SpawnGo());
    }
    public IEnumerator SpawnGo()
    {
        for (int i = 0; i < pointSpavn.Length; i++)
        {
            Instantiate(_zombiePrefab, pointSpavn[i].transform.position, transform.rotation);
            _numberOfZombies--;
        }
        yield return new WaitForSeconds(delaySpawn);
        if (_numberOfZombies <= 0)
        {
            yield break;
        }
        else
        {
            StartCoroutine(SpawnGo());
        }
    }
}
