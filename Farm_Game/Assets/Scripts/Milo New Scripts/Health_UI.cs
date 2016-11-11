using UnityEngine;
using UnityEngine.UI;

public class Health_UI : MonoBehaviour {

    public Text livestext;
    GameObject player;
    
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        
        livestext.text = "Health: " + player.GetComponent<HealthScript>().Lives;
    }
}
