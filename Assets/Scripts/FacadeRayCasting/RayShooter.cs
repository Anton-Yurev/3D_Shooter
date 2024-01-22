using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static UnityEditor.PlayerSettings;
using static WeaponCartridges;

public class RayShooter : MonoBehaviour
{
    public Action shoot;
    public Action bulletNow;

    [SerializeField] AudioSource _shootSound;
    int damage = 50;
    private Camera _camera;

    float _timer = 0;

    [SerializeField] int _cartridges = 15;
    public int Cartridges => this._cartridges;

    [SerializeField] float _delayShoot = 0.5f;
    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    public void OnGUI()
    {
        int size = 12;
        float PosX = _camera.pixelWidth / 2 - size / 4;
        float PosY = _camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(PosX, PosY, size, size), "*");
    }
    public void Shoot()
    {
        if ((_timer += Time.deltaTime) >= _delayShoot)
        {

            if (Input.GetMouseButton(0) && _cartridges > 0)
            {
                
                Debug.Log("shot");
                _shootSound.Play();
                _cartridges--;
                shoot?.Invoke();
                Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
                Ray ray = _camera.ScreenPointToRay(point);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.TryGetComponent(out IReactionOnDamage reactionOnDamage))
                    {
                        reactionOnDamage.ReactionOnDamage(damage);
                    }
                }
                _timer = 0;
            }
        }
    }

    public void ReplenishAmmunition(int bulletNew)
    {
        _cartridges += bulletNew;
        bulletNow();
    }

}
