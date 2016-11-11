using UnityEngine;
using System.Collections;

public class Health_enemies : MonoBehaviour
{
    public GameObject objectToDestroy;
    GameObject gamemaster;
    private int _score;

    void Start()
    {
        gamemaster = GameObject.Find("GameMaster");
    }

    void OnMouseDown()
    {
        _score = gamemaster.GetComponent<ScoreScript>().Score += 50;
        Destroy(objectToDestroy);
    }
}