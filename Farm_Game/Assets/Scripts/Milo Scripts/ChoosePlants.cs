using UnityEngine;
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
        buildManager.SetTimerToTime(buildManager.timing[0]);
    }

    public void chooseCarrotSeeds()
    {
        buildManager.SetSeedToPlant(buildManager.Seeds[1]);
    }

    public void chooseStrawberrySeeds()
    {
        buildManager.SetSeedToPlant(buildManager.Seeds[2]);
    }

    public void chooseCornSeeds()
    {
        buildManager.SetSeedToPlant(buildManager.Seeds[3]);
    }
}
