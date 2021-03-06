﻿using UnityEngine;
/// <summary>
/// This class lets u choose the different seeds to plant;
/// </summary>

public class ChoosePlants : MonoBehaviour {

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void chooseTomatoSeeds() {
        buildManager.SetSeedToPlant(buildManager.Seeds[0]);
        buildManager.buttonToSet(buildManager.button[0]);
    }

    public void chooseCarrotSeeds()
    {
        buildManager.SetSeedToPlant(buildManager.Seeds[1]);
        buildManager.buttonToSet(buildManager.button[1]);
    }

    public void chooseStrawberrySeeds()
    {
        buildManager.SetSeedToPlant(buildManager.Seeds[2]);
        buildManager.buttonToSet(buildManager.button[2]);
    }

    public void chooseCornSeeds()
    {
        buildManager.SetSeedToPlant(buildManager.Seeds[3]);
        buildManager.buttonToSet(buildManager.button[3]);
    }
}
