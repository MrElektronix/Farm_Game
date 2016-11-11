using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
    public float Score;
    GameObject gamemaster;
    private float _time;
    private int _lives;
    private bool gameOver = false;

    // Use this for initialization
    void Start () {
        Score = 0;
        gamemaster = GameObject.Find("GameMaster");
    }
	
	// Update is called once per frame
	void Update () {
        CalculateScore();
    }

    public void CalculateScore()
    {
        _time = gamemaster.GetComponent<TimerScript>().time;
        _lives = gamemaster.GetComponent<HealthScript>().Lives;
        if (_time <= 0)
        {
            
        }
        else
        {
            Score += 20;
        }
       


        Debug.Log("Score: " + Score);
    }
}
