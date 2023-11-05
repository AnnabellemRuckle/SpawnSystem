using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DayFactory : AbstractFactory
{
    public GameObject dayObjectPrefab;

    public override GameObject CreateObject()
    {
        return Instantiate(dayObjectPrefab);
    }
}
