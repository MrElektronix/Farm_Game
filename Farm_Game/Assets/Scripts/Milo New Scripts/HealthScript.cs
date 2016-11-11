using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

    public int Lives;
    private int EnemyDamage;
    private float _score;
    GameObject gamemaster;

    // Use this for initialization
    void Start () {
        Lives = 100;
        EnemyDamage = 5;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Lives <= 0)
        {
            Lives = 0;
        }
        gamemaster = GameObject.Find("GameMaster");
        
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Enemy"))
        {
            Lives -= EnemyDamage;
            Destroy(other.gameObject);
        }
    }
}
