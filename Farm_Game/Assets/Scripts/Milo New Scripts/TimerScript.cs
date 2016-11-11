using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour {

    public float time;

	// Use this for initialization
	void Start () {
        time = 50;
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
