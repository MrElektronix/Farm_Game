using UnityEngine;

public class BuildManager : MonoBehaviour {
    public static BuildManager instance;

    void Awake() {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
            return;
        }
        instance = this;
    }

    public GameObject tomatoPlant;
    public GameObject tomatoPlantTimer;

    public GameObject carrotPlant;
    public GameObject strawberryPlant;
    public GameObject cornPlant;


    private GameObject plantToPlant;

    public GameObject GetPlantToPlant()
    {
        return plantToPlant;
    }

    public void SetPlantToPlant(GameObject plant)
    {
        plantToPlant = plant;
    }

    private GameObject timerToTime;

    public GameObject GetTimerToTime()
    {
        return timerToTime;
    }

    public void SetTimerToTime(GameObject timing)
    {
        timerToTime = timing;
    }
}
