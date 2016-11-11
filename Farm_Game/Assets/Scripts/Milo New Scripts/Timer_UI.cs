using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer_UI : MonoBehaviour {

    public Text timertext;
    GameObject gamemaster;

    // Use this for initialization
    void Start()
    {
        gamemaster = GameObject.Find("GameMaster");
    }

    // Update is called once per frame
    void Update()
    {

        timertext.text = "Time: " + gamemaster.GetComponent<TimerScript>().time.ToString("0");
    }
}
