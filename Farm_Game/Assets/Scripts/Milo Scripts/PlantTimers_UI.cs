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
        

	}
	
	// Update is called once per frame
	public void Update () {
        for (int i = 0; i < TextToDisplay.Length; i++)
        {
            switch (i)
            {
                case 0:
                    TextToDisplay[i].text = "Tomato: " +  " sec.";
                    break;
                case 1:
                    TextToDisplay[i].text = "Carrot " +  " sec.";
                    break;
                case 2:
                    TextToDisplay[i].text = "Strawberry: " + " sec.";
                    break;
                case 3:
                    TextToDisplay[i].text = "Corn: " +  " sec.";
                    break;
                default:
                    break;
            }
            //Debug.Log(TextToDisplay[i].ToString() + planttimers.Times[i].ToString());
        }
	}
}
