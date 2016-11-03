using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimersUI_Plants : MonoBehaviour {

    [SerializeField]
    private Text _TomatoText;

    [SerializeField]
    private Text _CarrotText;

    [SerializeField]
    private Text _StrawberryText;

    [SerializeField]
    private Text _CornText;

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetTimerTextPlants(string text, float time) {
        GameObject timecontroller = GameObject.Find("TimeController");
        Timers_Plants timerplants = timecontroller.GetComponent<Timers_Plants>();

        switch (text)
        {
            case "Tomato":
                _TomatoText.text = "Tomato " + timerplants.TomatoTime.ToString("0") + " sec.";
                break;
            case "Carrot":
                _CarrotText.text = "Carrot: " + timerplants.CarrotTime.ToString("0" ) + " sec.";
                break;
            case "Strawberry":
                _StrawberryText.text = "Strawberry: " + timerplants.StrawberryTime.ToString("0") + " sec.";
                break;
            case "Corn":
                _CornText.text = "Corn: " + timerplants.CornTime.ToString("0") + " sec.";
                break;
            default:
                break;
        }
    }
}
