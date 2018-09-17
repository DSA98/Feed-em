using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketManagerUI : MonoBehaviour {

	public void SellWheat()
    {
        if (SingletonResources.ResourcesInstance.Wheat >= 5)
        {
            SingletonResources.ResourcesInstance.Wheat -= 5;
            SingletonResources.ResourcesInstance.Money += 30;
        }
        else
        {
            print("You Dont have enough wheat for selling");
        }
    }
    public void SellMilk()
    {
        if (SingletonResources.ResourcesInstance.Milk >= 5)
        {
            SingletonResources.ResourcesInstance.Milk -= 5;
            SingletonResources.ResourcesInstance.Money += 20;
        }
        else
        {
            print("You Dont have enough milk for selling");
        }
    }
    public void SellEggs()
    {
        if (SingletonResources.ResourcesInstance.Eggs >= 5)
        {
            SingletonResources.ResourcesInstance.Eggs -= 5;
            SingletonResources.ResourcesInstance.Money += 25;
        }
        else
        {
            print("You Dont have enough Eggs for selling");
        }
    }
    public void DonateWheat()
    {
        if (SingletonResources.ResourcesInstance.Wheat >= 5)
        {
            if(SingletonResources.ResourcesInstance.AnimalsSupplies + 5 < 100)
            {
                SingletonResources.ResourcesInstance.Wheat -= 5;
                SingletonResources.ResourcesInstance.AnimalsSupplies += 5;
            }
            else
            {
                print("The animals have plenty of food thx to you");
            }
        }
        else
        {
            print("You Dont have enough wheat for selling");
        }
    }
    public void DonateMilk()
    {
        if (SingletonResources.ResourcesInstance.Milk >= 5)
        {
            if (SingletonResources.ResourcesInstance.AnimalsSupplies + 5 < 100)
            {
                SingletonResources.ResourcesInstance.Milk -= 5;
                SingletonResources.ResourcesInstance.AnimalsSupplies += 5;
            }
            else
            {
                print("The animals have plenty of food thx to you");
            }
        }
        else
        {
            print("You Dont have enough Milk for selling");
        }
    }
    public void DonateEggs()
    {
        if (SingletonResources.ResourcesInstance.Eggs >= 5)
        {
            if (SingletonResources.ResourcesInstance.AnimalsSupplies + 5 < 100)
            {
                SingletonResources.ResourcesInstance.Eggs -= 5;
                SingletonResources.ResourcesInstance.AnimalsSupplies += 5;
            }
            else
            {
                print("The animals have plenty of food thx to you");
            }
        }
        else
        {
            print("You Dont have enough Eggs for selling");
        }
    }
}
