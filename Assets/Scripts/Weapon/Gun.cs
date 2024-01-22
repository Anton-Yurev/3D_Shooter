using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    protected override int damage { get => 15;  }
    protected override float delayShoot { get => 1;  }

}
