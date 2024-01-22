using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeaponCartridges : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshProUGUI;
    [SerializeField] RayShooter rayShooter;

    public delegate void WeaponCartridge();
    private void Start()
    {
        textMeshProUGUI.text=rayShooter.Cartridges.ToString();
        WeaponCartridge weaponCartridge = CartridgesNow;
    }
    //private void Update()
    //{
    //    CartridgesNow();
    //}

    public void CartridgesNow()
    {
        textMeshProUGUI.text = rayShooter.Cartridges.ToString();
    }
    private void OnEnable()
    {
        rayShooter.shoot += CartridgesNow;
        rayShooter.bulletNow += CartridgesNow;
    }
    private void OnDisable()
    {
        rayShooter.shoot -= CartridgesNow;
        rayShooter.bulletNow -= CartridgesNow;
    }
}
