using UnityEngine;
using System.Collections;

public class plantBTN : MonoBehaviour {

    [SerializeField]
    private GameObject plantPrefab;

    [SerializeField]
    private Sprite sprite;


    public GameObject PlantPrefab
    {
        get
        {
            return plantPrefab;
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
