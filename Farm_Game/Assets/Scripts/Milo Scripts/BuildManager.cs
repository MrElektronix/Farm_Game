using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
            return;
        }
        instance = this;
    }

    public GameObject[] Seeds;
    public GameObject[] button;

    private GameObject seedsToPlant;

    public GameObject GetSeedToPlant()
    {
        return seedsToPlant;
    }

    public void SetSeedToPlant(GameObject Seeds)
    {
        seedsToPlant = Seeds;
    }

    private GameObject buttonToGet;

    public GameObject GetButton()
    {
        return buttonToGet;
    }

    public void buttonToSet(GameObject button)
    {
        buttonToGet = button;
    }



}

