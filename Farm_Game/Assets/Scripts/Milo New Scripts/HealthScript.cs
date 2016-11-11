using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

    public int Lives;

	// Use this for initialization
	void Start () {
        Lives = 50;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Lives <= 0)
        {
            Lives = 0;
        }
	}

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Enemy"))
        {
            Lives -= 10;
            Destroy(other.gameObject);
        }
    }
}
