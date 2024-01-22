using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour, IReactionOnDamage
{
    [SerializeField] GameObject _smallExplosionEffectPrfab;
    [SerializeField] float _radius = 3f;
    [SerializeField] int _damage = 100;
    MeshRenderer _renderer;
    AudioSource _audioSource;
    bool _status;
    float _detonationTime = 0.4f;
    private void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        _audioSource = GetComponent<AudioSource>();
    }
    public void ReactionOnDamage(int damage)
    {
        if (_status) return;
        _status = true;
        Bang();
    }

    private void Bang()
    {
        Collider[] overlappedColiders = Physics.OverlapSphere(transform.position, _radius);
        for (int i = 0; i < overlappedColiders.Length; i++)
        {
            if (overlappedColiders[i].TryGetComponent(out IReactionOnDamage reactionOnDamage))
            {
                reactionOnDamage.ReactionOnDamage(_damage);
            }
        }
        StartCoroutine(VisualBang());
    }
    private IEnumerator VisualBang()
    {
        _audioSource.Play();
        GameObject flame = Instantiate(_smallExplosionEffectPrfab, transform.position, transform.rotation);
        _renderer.enabled = false;
        yield return new WaitForSeconds(1f);
        Destroy(flame);
        Destroy(this.gameObject);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _radius);
    }
}
