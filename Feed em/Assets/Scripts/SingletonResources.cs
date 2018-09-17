using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonResources {

    private static SingletonResources resourcesInstance = null;
    public static SingletonResources ResourcesInstance
    {
        get
        {
            if (resourcesInstance == null)
            {
                resourcesInstance = new SingletonResources();
            }
            return resourcesInstance;
        }
    }

    //Attributes
    private int wheat = 0;
    private int seeds = 5;
    private int milk = 0;
    private int money = 2000;
    private float water = 100f;
    private float maxWaterCapacity = 100f;
    private int eggs = 0;
    private int storage = 0;
    private int maxStorageCapacity = 50;
    private int animalsSupplies = 100;
    
    // Properties
    public int Money
    {
        get
        {
            return money;
        }

        set
        {
            money = value;
        }
    }
    public int Milk
    {
        get
        {
            return milk;
        }

        set
        {
            milk = value;
        }
    }
    public int Wheat
    {
        get
        {
            return wheat;
        }

        set
        {
            wheat = value;
        }
    }
    public int Seeds
    {
        get
        {
            return seeds;
        }

        set
        {
            seeds = value;
        }
    }
    public float Water
    {
        get
        {
            return water;
        }

        set
        {
            water = Mathf.Clamp(value, 0, maxWaterCapacity);
        }
    }
    public float MaxWaterCapacity
    {
        get
        {
            return maxWaterCapacity;
        }

        set
        {
            maxWaterCapacity = value;
        }
    }
    public int Eggs
    {
        get
        {
            return eggs;
        }

        set
        {
            eggs = value;
        }
    }
    public int Storage
    {
        get
        {
            return storage;
        }

        set
        {
            storage = value;
        }
    }
    public int MaxStorageCapacity
    {
        get
        {
            return maxStorageCapacity;
        }

        set
        {
            maxStorageCapacity = value;
        }
    }
    public int AnimalsSupplies
    {
        get
        {
            return animalsSupplies;
        }

        set
        {
            animalsSupplies = Mathf.Clamp(value, 0, 100);
        }
    }
}
