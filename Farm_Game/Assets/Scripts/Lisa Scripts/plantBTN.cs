using UnityEngine;
using System.Collections;

public class plantBTN : MonoBehaviour {

    [SerializeField]
    private GameObject plantPrefab;

    [SerializeField]
    private Sprite sprite;

    [SerializeField]
    private GameObject timer;


    public GameObject PlantPrefab
    {
        get
        {
            return plantPrefab;
        }

    }

    public GameObject Timer
    {
        get
        {
            return timer;
        }

    }

    public Sprite Sprite
    {
        get
        {
            return sprite;
        }

    }
}
