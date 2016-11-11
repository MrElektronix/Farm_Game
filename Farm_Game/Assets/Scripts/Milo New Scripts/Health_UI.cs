using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health_UI : MonoBehaviour {

    public Text livestext;
    GameObject gamemaster;
    
	// Use this for initialization
	void Start () {
        gamemaster = GameObject.Find("GameMaster");
	}
	
	// Update is called once per frame
	void Update () {
        
        livestext.text = "Health: " + gamemaster.GetComponent<HealthScript>().Lives;
    }
}
