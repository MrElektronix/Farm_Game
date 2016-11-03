using UnityEngine;
using System.Collections;

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

    void Start() {
        plantToPlant = tomatoPlant;
    }

    private GameObject plantToPlant;

    public GameObject GetPlantToPlant()
    {
        return plantToPlant;
    }
}
