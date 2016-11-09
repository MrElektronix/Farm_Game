using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour {

    public Text buttonText;
	// Use this for initialization
	void Start () {
        buttonText = this.GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
