using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightFactory : AbstractFactory
{
    public GameObject nightObjectPrefab;

    public override GameObject CreateObject()
    {
        return Instantiate(nightObjectPrefab);
    }
}
