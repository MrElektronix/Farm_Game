using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
    public float Score;
    GameObject gamemaster;
    GameObject player;
    private float _time;
    private int _lives;

    // Use this for initialization
    void Start () {
        Score = 0;
        gamemaster = GameObject.Find("GameMaster");
        player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
        CalculateScore();
    }

    public void CalculateScore()
    {
        _time = gamemaster.GetComponent<TimerScript>().time;
        _lives = player.GetComponent<HealthScript>().Lives;
        if (_time <= 0 )
        {
            
        }
        else
        {
            Score += 20;
        }
       


        //Debug.Log("Score: " + Score);
    }
}
