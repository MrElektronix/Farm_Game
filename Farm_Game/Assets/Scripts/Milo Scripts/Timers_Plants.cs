using UnityEngine;
using System.Collections;

public class Timers_Plants : MonoBehaviour {

    public float TomatoTime = 5;
    public float CarrotTime = 2;
    public float StrawberryTime = 10;
    public float CornTime = 3;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        TomatoTime -= Time.deltaTime;
        TomatoTime = Mathf.Round(TomatoTime * 100f) / 100f;
        Timer();
    }

    void Timer()
    {
        if (TomatoTime <= 0f) { TomatoTime = 0f; }
        if (CarrotTime <= 0f) { CarrotTime = 0f; }
        if(StrawberryTime <= 0f) { StrawberryTime = 0f; }
        if (CornTime <= 0f) { CornTime = 0f;}

        GameObject Cube = GameObject.Find("Cube");
        TimersUI_Plants timeruiplants = Cube.GetComponent<TimersUI_Plants>();

        timeruiplants.SetTimerTextPlants("Tomato", TomatoTime);
        timeruiplants.SetTimerTextPlants("Carrot", CarrotTime);
        timeruiplants.SetTimerTextPlants("Strawberry", StrawberryTime);
        timeruiplants.SetTimerTextPlants("Corn", CornTime);

    }

}
