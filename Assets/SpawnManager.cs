using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnManager : MonoBehaviour
{
    public DayFactory dayFactory;
    public NightFactory nightFactory;
    private GameObject spawnedObject;

    private void Start()
    {
        dayFactory = GetComponentInChildren<DayFactory>();
        nightFactory = GetComponentInChildren<NightFactory>();
    }

    public void SpawnBasedOnTimeOfDay(bool isDay)
    {
        AbstractFactory factory;
        Vector3 spawnPosition = new Vector3(462.25f, 242.25f, 0f);

        if (isDay)
        {
            factory = dayFactory;
        }
        else
        {
            factory = nightFactory;
        }
        if (spawnedObject != null)
        {
            Destroy(spawnedObject);
        }
        spawnedObject = factory.CreateObject();
        spawnedObject.transform.position = spawnPosition;
    }
}
