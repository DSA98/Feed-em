using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBuildingsPools : MonoBehaviour {

    //All variables assigned for the poolScript
    #region Variables
    //Contruction of a singleton for global use
    private static CreateBuildingsPools createBuildingsInstance = null;
    public static CreateBuildingsPools CreateBuildingsInstance
    {
        get
        {
            return createBuildingsInstance;
        }
    }

    //Objects for pooling
    [SerializeField] private GameObject farmObj = null, milkFactoryObj = null, barnObj = null, eggsFactoryObj = null, farmLandObj = null;

    //Lists of pools
    private List<GameObject> farmPoolList, milkFactoryPoolList, barnPoolList, eggsFactoryPoolList, farmLandPoolList;

    //Declare the range of the initial pool
    [SerializeField]
    private int farmPoolSize = 6, milkFactoryPoolSize = 6, barnPoolSize = 6, eggsFactoryPoolSize = 6, farmLandPoolSize = 6;
    #endregion

    //Initialize the static class
    private void Awake()
    {
        //Creation of instance
        if (createBuildingsInstance == null)
        {
            createBuildingsInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //Initialize all initial pools
    void Start () {
        //Initialize List
        farmPoolList = new List<GameObject>();
        milkFactoryPoolList = new List<GameObject>();
        barnPoolList = new List<GameObject>();
        eggsFactoryPoolList = new List<GameObject>();
        farmLandPoolList = new List<GameObject>();
        //Arrange all objects according to it's pool number
        for (int i = 0; i < farmPoolSize; i++)
        {
            GameObject cloneFarm = Instantiate(farmObj);
            cloneFarm.SetActive(false);
            farmPoolList.Add(cloneFarm);
        }
        for (int i = 0; i < milkFactoryPoolSize; i++)
        {
            GameObject cloneMilkFactory = Instantiate(milkFactoryObj);
            cloneMilkFactory.SetActive(false);
            milkFactoryPoolList.Add(cloneMilkFactory);
        }
        for (int i = 0; i < barnPoolSize; i++)
        {
            GameObject cloneBarn = Instantiate(barnObj);
            cloneBarn.SetActive(false);
            barnPoolList.Add(cloneBarn);
        }
        for (int i = 0; i < eggsFactoryPoolSize; i++)
        {
            GameObject cloneEggsFactory = Instantiate(eggsFactoryObj);
            cloneEggsFactory.SetActive(false);
            eggsFactoryPoolList.Add(cloneEggsFactory);
        }
        for (int i = 0; i < farmLandPoolSize; i++)
        {
            GameObject cloneFarmLand = Instantiate(farmLandObj);
            cloneFarmLand.SetActive(false);
            farmLandPoolList.Add(cloneFarmLand);
        }
    }
	
    //Function get a farm object
    public GameObject GetFarmPool()
    {
        if (farmPoolList.Count > 0)
        {
            return AllocateFarmPoolObject();
        }
        if (farmPoolList.Count <= 0)
        {
            ProduceFarmPool();
            return AllocateFarmPoolObject();
        }
        return null;
    }
    //Function get a MilkFactory object
    public GameObject GetMilkFactoryPool()
    {
        if (milkFactoryPoolList.Count > 0)
        {
            return AllocateMilkFactoryPoolObject();
        }
        if (milkFactoryPoolList.Count <= 0)
        {
            ProduceMilkFactoryPool();
            return AllocateMilkFactoryPoolObject();
        }
        return null;
    }
    //Function get a Barn object
    public GameObject GetBarnPool()
    {
        if (barnPoolList.Count > 0)
        {
            return AllocateBarnPoolObject();
        }
        if (barnPoolList.Count <= 0)
        {
            ProduceBarnPool();
            return AllocateBarnPoolObject();
        }
        return null;
    }
    //Function get an EggsFactory object
    public GameObject GetEggsFactoryPool()
    {
        if (eggsFactoryPoolList.Count > 0)
        {
            return AllocateEggsFactoryPoolObject();
        }
        if (eggsFactoryPoolList.Count <= 0)
        {
            ProduceEggsFactoryPool();
            return AllocateEggsFactoryPoolObject();
        }
        return null;
    }
    //Function get an FarmLand object
    public GameObject GetFarmLandPool()
    {
        if (farmLandPoolList.Count > 0)
        {
            return AllocateFarmLandPoolObject();
        }
        if (farmLandPoolList.Count <= 0)
        {
            ProduceFarmLandPool();
            return AllocateFarmLandPoolObject();
        }
        return null;
    }

    //In case of not having an available object in the pool we create another one with the following functions
    public void ProduceFarmPool()
    {
        GameObject cloneObjectPool = Instantiate(farmObj);
        cloneObjectPool.SetActive(false);
        farmPoolList.Add(cloneObjectPool);
    }
    public void ProduceMilkFactoryPool()
    {
        GameObject cloneObjectPool = Instantiate(milkFactoryObj);
        cloneObjectPool.SetActive(false);
        milkFactoryPoolList.Add(cloneObjectPool);
    }
    public void ProduceBarnPool()
    {
        GameObject cloneObjectPool = Instantiate(barnObj);
        cloneObjectPool.SetActive(false);
        barnPoolList.Add(cloneObjectPool);
    }
    public void ProduceEggsFactoryPool()
    {
        GameObject cloneObjectPool = Instantiate(eggsFactoryObj);
        cloneObjectPool.SetActive(false);
        eggsFactoryPoolList.Add(cloneObjectPool);
    }
    public void ProduceFarmLandPool()
    {
        GameObject cloneObjectPool = Instantiate(farmLandObj);
        cloneObjectPool.SetActive(false);
        farmLandPoolList.Add(cloneObjectPool);
    }

    //Allocate or assign an object from the pools
    public GameObject AllocateFarmPoolObject()
    {
        for (int i = 0; i < farmPoolList.Count; i++)
        {
            //In case of an inactive object in the pool
            if (!farmPoolList[i].activeInHierarchy)
            {
                //We return the pool object and we eliminate it from the list for it's use
                GameObject objectForPooling = farmPoolList[i];
                farmPoolList.Remove(farmPoolList[i]);
                return objectForPooling;
            }
        }
        return null;
    }
    public GameObject AllocateMilkFactoryPoolObject()
    {
        for (int i = 0; i < milkFactoryPoolList.Count; i++)
        {
            //In case of an inactive object in the pool
            if (!milkFactoryPoolList[i].activeInHierarchy)
            {
                //We return the pool object and we eliminate it from the list for it's use
                GameObject objectForPooling = milkFactoryPoolList[i];
                milkFactoryPoolList.Remove(milkFactoryPoolList[i]);
                return objectForPooling;
            }
        }
        return null;
    }
    public GameObject AllocateBarnPoolObject()
    {
        for (int i = 0; i < barnPoolList.Count; i++)
        {
            //In case of an inactive object in the pool
            if (!barnPoolList[i].activeInHierarchy)
            {
                //We return the pool object and we eliminate it from the list for it's use
                GameObject objectForPooling = barnPoolList[i];
                barnPoolList.Remove(barnPoolList[i]);
                return objectForPooling;
            }
        }
        return null;
    }
    public GameObject AllocateEggsFactoryPoolObject()
    {
        for (int i = 0; i < eggsFactoryPoolList.Count; i++)
        {
            //In case of an inactive object in the pool
            if (!eggsFactoryPoolList[i].activeInHierarchy)
            {
                //We return the pool object and we eliminate it from the list for it's use
                GameObject objectForPooling = eggsFactoryPoolList[i];
                eggsFactoryPoolList.Remove(eggsFactoryPoolList[i]);
                return objectForPooling;
            }
        }
        return null;
    }
    public GameObject AllocateFarmLandPoolObject()
    {
        for (int i = 0; i < farmLandPoolList.Count; i++)
        {
            //In case of an inactive object in the pool
            if (!farmLandPoolList[i].activeInHierarchy)
            {
                //We return the pool object and we eliminate it from the list for it's use
                GameObject objectForPooling = farmLandPoolList[i];
                farmLandPoolList.Remove(farmLandPoolList[i]);
                return objectForPooling;
            }
        }
        return null;
    }

    //Function Return gives the gameobject back to the pool
    public void ReturnGameObjectFarm(GameObject _gamObjectFarm)
    {
        _gamObjectFarm.SetActive(false);
        farmPoolList.Add(_gamObjectFarm);
    }
    public void ReturnGameObjectMilkFactory(GameObject _gamObjectMilkFactory)
    {
        _gamObjectMilkFactory.SetActive(false);
        milkFactoryPoolList.Add(_gamObjectMilkFactory);
    }
    public void ReturnGameObjectBarn(GameObject _gamObjectBarn)
    {
        _gamObjectBarn.SetActive(false);
        barnPoolList.Add(_gamObjectBarn);
    }
    public void ReturnGameObjectEggsFactory(GameObject _gamObjectEggsFactory)
    {
        _gamObjectEggsFactory.SetActive(false);
        eggsFactoryPoolList.Add(_gamObjectEggsFactory);
    }
    public void ReturnGameObjectFarmLand(GameObject _gamObjectFarmLand)
    {
        _gamObjectFarmLand.SetActive(false);
        eggsFactoryPoolList.Add(_gamObjectFarmLand);
    }
}
