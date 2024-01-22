using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected Camera _camera;
    protected abstract int damage { get;  }
    protected int cartridges;

    protected abstract float delayShoot { get;  }

    private float _timer = 0;

    private void Awake()
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
        if ((_timer += Time.deltaTime) >= delayShoot)
        {
            if (Input.GetMouseButton(0) && cartridges > 0)
            {
                Debug.Log("shot");
                cartridges--;
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
}
