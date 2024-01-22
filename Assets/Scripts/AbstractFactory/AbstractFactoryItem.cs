using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFactoryItem : MonoBehaviour
{
    public abstract GameObject CreateBarrel();
    public abstract GameObject CreateFirstAidKit();
    public abstract GameObject CreateAmmoBox();
}
