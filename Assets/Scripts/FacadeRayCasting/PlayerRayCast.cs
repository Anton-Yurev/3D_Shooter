using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRayCast : MonoBehaviour
{
    [SerializeField] RayShooter rayShooter;
    FacadeRayCast _facadeRayCast;
    void Start()
    {
        _facadeRayCast = new FacadeRayCast(rayShooter);
    }
    void Update()
    {
        _facadeRayCast.Shoot();
    }

}
