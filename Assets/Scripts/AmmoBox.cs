using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    RayShooter _rayShooter;
    [SerializeField] int quantityOfammunition=15;
    private void Start()
    {
        _rayShooter = FindObjectOfType<RayShooter>();
    }
    private void OnTriggerEnter(Collider other)
    {
        _rayShooter.ReplenishAmmunition(quantityOfammunition);
        Destroy(gameObject);
    }
}
