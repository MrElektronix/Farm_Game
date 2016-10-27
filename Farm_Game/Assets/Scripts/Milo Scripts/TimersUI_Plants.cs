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
        //GameObject Player = GameObject.Find("Player");
        //Timers_Plants timerplants = Player.GetComponent<Timers_Plants>();

        switch (text)
        {
            case "Tomato":
                _TomatoText.text = "Tomato: " + time.ToString();
                break;
            case "Carrot":
                _CarrotText.text = "Carrot: " + time.ToString();
                break;
            case "Strawberry":
                _StrawberryText.text = "Strawberry: " + time.ToString();
                break;
            case "Corn":
                _CornText.text = "Corn: " + time.ToString();
                break;
            default:
                break;
        }
    }
}
