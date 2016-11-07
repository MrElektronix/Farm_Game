using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// This class displays the times;
/// </summary>

public class PlantTimers_UI : MonoBehaviour {
    public static PlantTimers_UI instance;

    public Text[] TextToDisplay;
    PlantTimers planttimers;

    void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
    }

	// Use this for initialization
	void Start () {
        planttimers = PlantTimers.instance;

	}
	
	// Update is called once per frame
	public void Update () {
        for (int i = 0; i < TextToDisplay.Length; i++)
        {
            switch (i)
            {
                case 0:
                    TextToDisplay[i].text = "Tomato: " + planttimers.Times[i].ToString("0") + " sec.";
                    break;
                case 1:
                    TextToDisplay[i].text = "Carrot " + planttimers.Times[i].ToString("0") + " sec.";
                    break;
                case 2:
                    TextToDisplay[i].text = "Strawberry: " + planttimers.Times[i].ToString("0") + " sec.";
                    break;
                case 3:
                    TextToDisplay[i].text = "Corn: " + planttimers.Times[i].ToString("0") + " sec.";
                    break;
                default:
                    break;
            }
            //Debug.Log(TextToDisplay[i].ToString() + planttimers.Times[i].ToString());
        }
	}
}
