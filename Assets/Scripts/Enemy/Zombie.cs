using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering.PostProcessing;

public class Zombie : MonoBehaviour, IReactionOnDamage
{
    public static Action ZombieIsDead;

    [SerializeField] int _healsZombie = 100;
    [SerializeField] Animator _animator;
    NavMeshAgent _navMeshAgent;
    ZombieMove _zombie;
    AttackZombie _attackZombie;

    private bool _alive = true;
    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _zombie = GetComponent<ZombieMove>();
        _attackZombie = GetComponent<AttackZombie>();
    }
    public void ReactionOnDamage(int damage)
    {
        if (_alive)
        {
            _healsZombie -= damage;
            if (_healsZombie <= 0)
            {
                _alive = false;
                StartCoroutine(Die());
            }
        }
    }
    private IEnumerator Die()
    {
        ZombieIsDead?.Invoke();
        _navMeshAgent.enabled = false;
        _zombie.enabled = false;
        _attackZombie.enabled = false;
        _animator.SetBool("Dead", true);
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }

}
