using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourcesUI : MonoBehaviour {

    [SerializeField]
    private Text eggsTxt, moneyTxt, seedsTxt, wheatTxt, milkTxt;
    [SerializeField]
    private Slider waterSlider, animalsSuppliesSlider, storageSlider;

    private bool lostCondition = false;

	void Awake () {
        eggsTxt.text = SingletonResources.ResourcesInstance.Eggs.ToString();
        moneyTxt.text = SingletonResources.ResourcesInstance.Money.ToString();
        seedsTxt.text = SingletonResources.ResourcesInstance.Seeds.ToString();
        wheatTxt.text = SingletonResources.ResourcesInstance.Wheat.ToString();
        milkTxt.text = SingletonResources.ResourcesInstance.Milk.ToString();
        waterSlider.maxValue = SingletonResources.ResourcesInstance.MaxWaterCapacity;
        waterSlider.value = SingletonResources.ResourcesInstance.Water;
        animalsSuppliesSlider.maxValue = 100;
        animalsSuppliesSlider.value = SingletonResources.ResourcesInstance.AnimalsSupplies;
        storageSlider.maxValue = SingletonResources.ResourcesInstance.MaxStorageCapacity;
        storageSlider.value = SingletonResources.ResourcesInstance.Storage;

        StartCoroutine(AnimalsHunger());
    }
	
	// Update is called once per frame
	void Update () {
        SingletonResources.ResourcesInstance.Storage = SingletonResources.ResourcesInstance.Milk + SingletonResources.ResourcesInstance.Eggs + SingletonResources.ResourcesInstance.Wheat;

        eggsTxt.text = SingletonResources.ResourcesInstance.Eggs.ToString();
        moneyTxt.text = SingletonResources.ResourcesInstance.Money.ToString();
        seedsTxt.text = SingletonResources.ResourcesInstance.Seeds.ToString();
        wheatTxt.text = SingletonResources.ResourcesInstance.Wheat.ToString();
        milkTxt.text = SingletonResources.ResourcesInstance.Milk.ToString();
        waterSlider.maxValue = SingletonResources.ResourcesInstance.MaxWaterCapacity;
        waterSlider.value = SingletonResources.ResourcesInstance.Water;
        animalsSuppliesSlider.value = SingletonResources.ResourcesInstance.AnimalsSupplies;
        storageSlider.maxValue = SingletonResources.ResourcesInstance.MaxStorageCapacity;
        storageSlider.value = SingletonResources.ResourcesInstance.Storage;

    }

    public IEnumerator AnimalsHunger()
    {
        while (!lostCondition)
        {
            yield return new WaitForSeconds(5f);
            SingletonResources.ResourcesInstance.AnimalsSupplies -= 5;
            if (SingletonResources.ResourcesInstance.AnimalsSupplies <= 0)
            {
                Time.timeScale = 0;
                print("Game Over");
            }
        }
    }
}
