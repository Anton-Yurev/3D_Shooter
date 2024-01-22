using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieMove : MonoBehaviour
{//застовляет врагов идти к игроку
    NavMeshAgent navMeshAgent;
    //PlayerCharacter player;
    [SerializeField] Transform pointAttack;

    void Start()
    {
        pointAttack = FindObjectOfType<PlayerCharacter>().transform;
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        transform.LookAt(pointAttack);
        navMeshAgent.SetDestination(pointAttack.transform.position);
    }
}
