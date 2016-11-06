using UnityEngine;

public class ChoosePlants : MonoBehaviour {

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void chooseTomatoSeeds() {
        buildManager.SetPlantToPlant(buildManager.tomatoPlant);
        buildManager.SetTimerToTime(buildManager.tomatoPlantTimer);
    }

    public void chooseCarrotSeeds()
    {
        buildManager.SetPlantToPlant(buildManager.carrotPlant);
    }

    public void chooseStrawberrySeeds()
    {
        buildManager.SetPlantToPlant(buildManager.strawberryPlant);
    }

    public void chooseCornSeeds()
    {
        buildManager.SetPlantToPlant(buildManager.cornPlant);
    }
}
