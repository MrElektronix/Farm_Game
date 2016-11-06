using UnityEngine;

public class Timers_Plants : MonoBehaviour {

    public float TomatoTime;
    public float CarrotTime;
    public float StrawberryTime;
    public float CornTime;

	// Use this for initialization
	void Start () {
               
    }
	
	// Update is called once per frame
	void Update () {
        /*
        TomatoTime -= RoundTimer(TomatoTime);
        CarrotTime -= RoundTimer(CarrotTime);
        StrawberryTime -= RoundTimer(StrawberryTime);
        CornTime -= RoundTimer(CornTime);
        */
        //Debug.Log(TomatoTime);
        TomatoTime -= Timer(TomatoTime);
        CarrotTime -= Timer(CarrotTime);
        StrawberryTime -= Timer(StrawberryTime);
        CornTime -= Timer(CornTime);

    }
    /*
    float RoundTimer(float plantTime)
    {
        float oldPlantTime = plantTime;
        //Debug.Log("oldPlantTime 1: " + oldPlantTime);
        plantTime -= Time.deltaTime;
        plantTime = Mathf.Round(plantTime * 100f) / 100f;
        oldPlantTime -= plantTime;
        //Debug.Log("oldPlantTime 2: " + oldPlantTime);
       // return oldPlantTime;
    }
    */
   

      

    float Timer(float plantTime)
    {
        float oldPlantTime = plantTime;
        //float minutes;
        //float seconds;
        if (plantTime <= 0f)
        {
            plantTime = 0f;
        }

        plantTime -= Time.deltaTime;

        /*
        minutes = Mathf.Floor(plantTime / 60);
        seconds = plantTime % 60;
        if (seconds > 59) { seconds = 59; }
        if (minutes < 0)
        {
            minutes = 0;
            seconds = 0;
        }
        */
        

        oldPlantTime -= plantTime;

        //Debug.Log(seconds);

        GameObject timecontroller = GameObject.Find("TimeController");
        TimersUI_Plants timeruiplants = timecontroller.GetComponent<TimersUI_Plants>();

        timeruiplants.SetTimerTextPlants("Tomato", TomatoTime);
        timeruiplants.SetTimerTextPlants("Carrot", CarrotTime);
        timeruiplants.SetTimerTextPlants("Strawberry", StrawberryTime);
        timeruiplants.SetTimerTextPlants("Corn", CornTime);

        return oldPlantTime;
        
    }

}
