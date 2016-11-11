using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour {

    public float time;
    GameObject gamemaster;

	// Use this for initialization
	void Start () {
        time = 10;
    }
	
	// Update is called once per frame
	void Update () {
	    if (time <= 0)
        {
            time = 0;
        }
        else
        {
            time -= Time.deltaTime;
        }
	}
}
