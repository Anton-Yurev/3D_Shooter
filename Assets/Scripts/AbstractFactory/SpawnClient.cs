using Assets.Scripts.AbstractFactory;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClient : MonoBehaviour
{
    [SerializeField] Transform point1;
    [SerializeField] Transform point2;
    [SerializeField] Transform point3;
    AbstractFactoryItem abstractFactoryItem;
    float spawnpositionX;
    float spawnpositionZ;
    public void CreateBarrelInScene()
    {
        abstractFactoryItem = new ÑonsumablesFactory(point1);
        abstractFactoryItem.CreateBarrel();
    }
    public void CreateFirstAidKitInScene()
    {
        abstractFactoryItem = new ÑonsumablesFactory(point2);
        abstractFactoryItem.CreateFirstAidKit();
    }
    public void CreateAmmoBoxInScene()
    {
        abstractFactoryItem = new ÑonsumablesFactory(point3);
        abstractFactoryItem.CreateAmmoBox();
    }

    private void Start()
    {
        StartCoroutine(SpawnBarrels());
    }

    public IEnumerator SpawnBarrels()
    {
        RandonPosition(point1);
        RandonPosition(point2);
        RandonPosition(point3);
        CreateBarrelInScene();
        CreateFirstAidKitInScene();
        CreateAmmoBoxInScene();
        yield return new WaitForSeconds(10);
        StartCoroutine(SpawnBarrels());
    }

    public void RandonPosition(Transform posit)
    {
        spawnpositionX = Random.Range(20, 80);
        spawnpositionZ = Random.Range(0, -70);
        posit.transform.position = new Vector3(spawnpositionX, 0.6f, spawnpositionZ);
    }
}
