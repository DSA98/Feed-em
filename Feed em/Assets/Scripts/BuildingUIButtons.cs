using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingUIButtons : MonoBehaviour {

    [SerializeField]
    private Building mBuilding;

    public void MoveBuilding()
    {
        Canvas objectCanvas = GetComponentInChildren<Canvas>();
        objectCanvas.transform.GetChild(0).gameObject.SetActive(false);
        objectCanvas.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(false);
        objectCanvas.transform.GetChild(0).transform.GetChild(2).gameObject.SetActive(false);
        mBuilding.IsPlaced = false;
        mBuilding.PlaceTime = 0.1f;
        BuildingController.BuildingControl.BuildingForConstruction = mBuilding;
    }

    public void TearBuildingDown()
    {
        Canvas objectCanvas = GetComponentInChildren<Canvas>();
        objectCanvas.transform.GetChild(0).gameObject.SetActive(false);
        objectCanvas.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(false);
        objectCanvas.transform.GetChild(0).transform.GetChild(2).gameObject.SetActive(false);
        mBuilding.IsPlaced = false;
        mBuilding.PlaceTime = 0.1f;
        mBuilding.IsBuilt = false;
        mBuilding.TimerBuilding = 0;
        if(mBuilding is Barn)
        {
            SingletonResources.ResourcesInstance.MaxStorageCapacity -= 20;
            CreateBuildingsPools.CreateBuildingsInstance.ReturnGameObjectBarn(mBuilding.gameObject);
        }
        if(mBuilding is BuildingsProducers)
        {
            mBuilding.GetComponent<BuildingsProducers>().ProductProduced = 0;
            CancelInvoke();
        }
        if(mBuilding is Farm)
        {
            CreateBuildingsPools.CreateBuildingsInstance.ReturnGameObjectFarm(mBuilding.gameObject);
        }
        if (mBuilding is FarmLand)
        {
            CreateBuildingsPools.CreateBuildingsInstance.ReturnGameObjectFarmLand(mBuilding.gameObject);
        }
        if (mBuilding is EggsFactory)
        {
            CreateBuildingsPools.CreateBuildingsInstance.ReturnGameObjectEggsFactory(mBuilding.gameObject);
        }
        if (mBuilding is MilkFactory)
        {
            CreateBuildingsPools.CreateBuildingsInstance.ReturnGameObjectMilkFactory(mBuilding.gameObject);
        }
    }
}
