using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkFactory : BuildingsProducers
{

    protected override void Awake() {
        base.Awake();
        buildingCost = 200;
        buildingTime = 5f;
    }

    public override void ProduceGoods()
    {
        if (SingletonResources.ResourcesInstance.Water - 2 > 0)
        {
            productProduced += 1;
            SingletonResources.ResourcesInstance.Water -= 2;
            print("Producing Milk");
        }
        else
        {
            print("No water for producing");
        }
    }

    public override void HarvestResources()
    {
        if (SingletonResources.ResourcesInstance.Storage < SingletonResources.ResourcesInstance.MaxStorageCapacity)
        {
            while (SingletonResources.ResourcesInstance.Storage <= SingletonResources.ResourcesInstance.MaxStorageCapacity)
            {
                if (productProduced > 0)
                {
                    SingletonResources.ResourcesInstance.Milk += 1;
                    productProduced -= 1;
                }
                else if (productProduced <= 0)
                {
                    uiPanel.gameObject.SetActive(false);
                    break;
                }
            }
        }
    }
}
