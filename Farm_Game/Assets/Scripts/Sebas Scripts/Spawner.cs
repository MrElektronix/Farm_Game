using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform spawner;
    public float movement;
    GameObject gamemaster;
    GameObject player;
    private float _time;
    private int _lives;
    private bool Spawning = true;


    void Start()
    {
        if (Spawning)
        {
            InvokeRepeating("Spawn", 2,4 );
        }
    }

    void Update()
    {
        gamemaster = GameObject.Find("GameMaster");
        player = GameObject.Find("Player");
        _time = gamemaster.GetComponent<TimerScript>().time;
        _lives = player.GetComponent<HealthScript>().Lives;
        
    }



    void Spawn()
    {
        if (_time <= 0 || _lives <= 0)
        {
            Debug.Log("Time's Up");
            Spawning = false;
        }
        else
        {
            Instantiate(enemy, spawner.position, spawner.rotation);
        }
       

    }
}
