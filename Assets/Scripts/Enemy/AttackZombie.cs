using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Threading.Tasks;
using System;

public class AttackZombie : MonoBehaviour
{
    [SerializeField] Animator _animator;
    NavMeshAgent navMeshAgent;
    float _distanceToThePlayer = 1.5f;

    float timeOfAttak;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void LateUpdate()
    {
        if (navMeshAgent.remainingDistance <= _distanceToThePlayer)
        {
            _animator.SetBool("Run", false);
            if ((timeOfAttak += Time.deltaTime) > 0.5f)
            {
                
                navMeshAgent.speed = 0;
                _animator.SetBool("Attack", true);
                timeOfAttak = 0f;
            }
        }
        else
        {
            _animator.SetBool("Attack", false);
            _animator.SetBool("Run", true);
            navMeshAgent.speed = 2.5f;
        }

    }
}
