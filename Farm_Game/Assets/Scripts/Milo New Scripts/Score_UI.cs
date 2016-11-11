using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score_UI : MonoBehaviour {

    public Text scoretext;
    GameObject gamemaster;

    // Use this for initialization
    void Start()
    {
        gamemaster = GameObject.Find("GameMaster");
    }

    // Update is called once per frame
    void Update()
    { 
        scoretext.text = "Score: " + gamemaster.GetComponent<ScoreScript>().Score.ToString("0");
    }
}
