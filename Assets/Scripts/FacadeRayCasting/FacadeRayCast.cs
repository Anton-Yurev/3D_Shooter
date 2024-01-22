using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacadeRayCast : MonoBehaviour
{
    RayShooter rayShooter;
    public FacadeRayCast(RayShooter rayShooter)
    {
        this.rayShooter = rayShooter;
    }

    public void Shoot()
    {
        rayShooter.Shoot();
    }
    public void ShowSight()
    {
        rayShooter.OnGUI();
    }
}
