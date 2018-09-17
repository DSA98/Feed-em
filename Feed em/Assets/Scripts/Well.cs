using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Well : Building {

    private int waterGiven = 10;
    private int costForActivation = 10;

    [SerializeField] private float grid = 0.5f;
    private float reciprocalGrid;

	// Use this for initialization
	protected override void Awake () {
        base.Awake();
        mRender.material.color = Color.green;
        isBuilt = true;
        canBePlaced = true;
        isPlaced = true;
        reciprocalGrid = 1f / grid;
        transform.position = new Vector3(Mathf.Round(transform.position.x * reciprocalGrid) / reciprocalGrid, transform.position.y, Mathf.Round(transform.position.z * reciprocalGrid) / reciprocalGrid);
    }
	
    public void GetWater()
    {
        if(SingletonResources.ResourcesInstance.Water < SingletonResources.ResourcesInstance.MaxWaterCapacity)
        {
            if (SingletonResources.ResourcesInstance.Money - costForActivation >= 0)
            {
                SingletonResources.ResourcesInstance.Money -= costForActivation;
                SingletonResources.ResourcesInstance.Water += waterGiven;
            }
            else
            {
                print("You have no money left");
            }
        }
        else
        {
            print("You have plenty of water");
        }
    }
}
