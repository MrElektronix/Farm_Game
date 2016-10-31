using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{


    public GameObject enemy;
    public Transform spawner;
    public float movement;
    


        
    void Start()
    {
        InvokeRepeating("Spawn", 2, 4);

     

    }



    void Spawn()
    {
        Instantiate(enemy, spawner.position, spawner.rotation);

    }
}
