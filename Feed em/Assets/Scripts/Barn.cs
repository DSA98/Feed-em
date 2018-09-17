using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barn : Building {

    // Use this for initialization
    protected override void Awake() {
        base.Awake();
        buildingCost = 300;
        buildingTime = 5f;
    }

    public IEnumerator RaiseStorageCapacity()
    {
        yield return new WaitForSeconds(buildingTime);
        SingletonResources.ResourcesInstance.MaxStorageCapacity += 20;
    }

    public void RaiseStorage()
    {
        SingletonResources.ResourcesInstance.MaxStorageCapacity += 20;
    }
}
