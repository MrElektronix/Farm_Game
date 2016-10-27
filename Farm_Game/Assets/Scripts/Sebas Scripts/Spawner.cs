using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{


    public GameObject enemy;
    public Transform spawner;
    public float movement;
    //public float spawnTime;



    void Start()
    {
        InvokeRepeating("Spawn", 2, 4);

        Debug.Log("teveel");

    }



    void Spawn()
    {
        Instantiate(enemy, spawner.position, spawner.rotation);

    }
}
