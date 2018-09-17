using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBuildingsButtons : MonoBehaviour {

    //All functions in this script are called from button listeners in the main canvas 
    public void GetFarmBuilding()
    {
        GameObject buildingPoolObject = CreateBuildingsPools.CreateBuildingsInstance.GetFarmPool();
        if (buildingPoolObject.GetComponent<Farm>().BuildingCost > SingletonResources.ResourcesInstance.Money || buildingPoolObject.GetComponent<Farm>().BuildingWaterCost > SingletonResources.ResourcesInstance.Water)
        {
            CreateBuildingsPools.CreateBuildingsInstance.ReturnGameObjectFarm(buildingPoolObject);
            print("You dont have enough resources");
        }
        else
        {
            BuildingController.BuildingControl.BuildingForConstruction = buildingPoolObject.GetComponent<Building>();
            buildingPoolObject.SetActive(true);
            buildingPoolObject.transform.rotation = Quaternion.identity;
        }
    }
    public void GetMilkFactoryBuilding()
    {
        GameObject buildingPoolObject = CreateBuildingsPools.CreateBuildingsInstance.GetMilkFactoryPool();
        if (buildingPoolObject.GetComponent<MilkFactory>().BuildingCost > SingletonResources.ResourcesInstance.Money || buildingPoolObject.GetComponent<MilkFactory>().BuildingWaterCost > SingletonResources.ResourcesInstance.Water)
        {
            CreateBuildingsPools.CreateBuildingsInstance.ReturnGameObjectMilkFactory(buildingPoolObject);
            print("You dont have enough resources");
        }
        else
        {
            BuildingController.BuildingControl.BuildingForConstruction = buildingPoolObject.GetComponent<Building>();
            buildingPoolObject.SetActive(true);
            buildingPoolObject.transform.rotation = Quaternion.identity;
        }
    }
    public void GetBarnBuilding()
    {
        GameObject buildingPoolObject = CreateBuildingsPools.CreateBuildingsInstance.GetBarnPool();
        if (buildingPoolObject.GetComponent<Barn>().BuildingCost > SingletonResources.ResourcesInstance.Money || buildingPoolObject.GetComponent<Barn>().BuildingWaterCost > SingletonResources.ResourcesInstance.Water)
        {
            CreateBuildingsPools.CreateBuildingsInstance.ReturnGameObjectBarn(buildingPoolObject);
            print("You dont have enough resources");
        }
        else
        {
            BuildingController.BuildingControl.BuildingForConstruction = buildingPoolObject.GetComponent<Building>();
            buildingPoolObject.SetActive(true);
            buildingPoolObject.transform.rotation = Quaternion.identity;
        }
    }
    public void GetEggsFactoryBuilding()
    {
        GameObject buildingPoolObject = CreateBuildingsPools.CreateBuildingsInstance.GetEggsFactoryPool();
        if (buildingPoolObject.GetComponent<EggsFactory>().BuildingCost > SingletonResources.ResourcesInstance.Money || buildingPoolObject.GetComponent<EggsFactory>().BuildingWaterCost > SingletonResources.ResourcesInstance.Water)
        {
            CreateBuildingsPools.CreateBuildingsInstance.ReturnGameObjectEggsFactory(buildingPoolObject);
            print("You dont have enough resources");
        }
        else 
        {
            BuildingController.BuildingControl.BuildingForConstruction = buildingPoolObject.GetComponent<Building>();
            buildingPoolObject.SetActive(true);
            buildingPoolObject.transform.rotation = Quaternion.identity;
        }
    }
    public void GetFarmLandBuilding()
    {
        GameObject buildingPoolObject = CreateBuildingsPools.CreateBuildingsInstance.GetFarmLandPool();
        if (buildingPoolObject.GetComponent<FarmLand>().BuildingCost > SingletonResources.ResourcesInstance.Money || buildingPoolObject.GetComponent<FarmLand>().BuildingWaterCost > SingletonResources.ResourcesInstance.Water)
        {
            CreateBuildingsPools.CreateBuildingsInstance.ReturnGameObjectFarmLand(buildingPoolObject);
            print("You dont have enough resources");
        }
        else
        {
            BuildingController.BuildingControl.BuildingForConstruction = buildingPoolObject.GetComponent<Building>();
            buildingPoolObject.SetActive(true);
            buildingPoolObject.transform.rotation = Quaternion.identity;
        }
    }
}
