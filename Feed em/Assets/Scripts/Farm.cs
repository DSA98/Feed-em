using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : BuildingsProducers
{
    protected override void Awake() {
        base.Awake();
        mRender.material.color = Color.red;
        buildingCost = 50;
        buildingWaterCost = 10;
        buildingTime = 10f;
        canBePlaced = false;
    }

    public override void ProduceGoods()
    {
        if (SingletonResources.ResourcesInstance.Water - 2 > 0)
        {
            productProduced += 1;
            SingletonResources.ResourcesInstance.Water -= 2;
            print("Producing Wheat");
        }
        else
        {
            print("No water for producing");
        }
    }

    public override void HarvestResources()
    {
        if(SingletonResources.ResourcesInstance.Storage < SingletonResources.ResourcesInstance.MaxStorageCapacity)
        {
            while(SingletonResources.ResourcesInstance.Storage <= SingletonResources.ResourcesInstance.MaxStorageCapacity)
            {
                if (productProduced > 0)
                {
                    SingletonResources.ResourcesInstance.Wheat += 1;
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

    protected override void OnTriggerEnter(Collider other)
    {
        if (!isPlaced)
        {
            if (other.gameObject.GetComponent<FarmLand>() != null)
            {
                canBePlaced = true;
                mRender.material.color = Color.magenta;
            }
        }
    }

    protected override void OnTriggerExit(Collider other)
    {
        if (!isBuilt)
        {
            if (other.gameObject.GetComponent<FarmLand>() != null)
            {
                canBePlaced = false;
                mRender.material.color = Color.red;
            }
        }
    }
}
