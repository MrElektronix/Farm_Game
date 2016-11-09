using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    public float time;
    public TimerUI timerButtonText;
    
    // Use this for initialization
    void Start()
    {

    }
    public void SetTimer(float timer)
    {
        this.time = timer;
    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            time = 0;
        }
        timerButtonText.buttonText.text = "" + time;
    }
}
