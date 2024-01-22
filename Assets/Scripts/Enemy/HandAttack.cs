using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAttack : MonoBehaviour
{
    PlayerCharacter character;
    private void OnTriggerEnter(Collider other)
    {
        character=other.GetComponent<PlayerCharacter>();
        character.ReactionOnDamage(15);
    }
}
