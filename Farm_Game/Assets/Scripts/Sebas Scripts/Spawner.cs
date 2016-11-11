using UnityEngine;
using UnityEngine.SceneManagement;

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
    private float SpawnTime;
    private Object Enemie;
    private int wave;


    void Start()
    {
        SpawnTime = 2.5f;
        if (Spawning)
        {
            InvokeRepeating("Spawn", 1, SpawnTime);
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
            Destroy(Enemie);
            Spawning = false;
            SceneManager.LoadScene(2);
        }
        else
        {
            Enemie = Instantiate(enemy, spawner.position, spawner.rotation);
        }
       

    }

}
