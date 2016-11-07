using UnityEngine;
/// <summary>
/// this class puts the different times in an array and counts down until it reaches 0;
/// </summary>

public class PlantTimers : MonoBehaviour {

    public static PlantTimers instance;
    public float[] Times;

    void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
    }

    // Update is called once per frame
    public void Update ()
    {
        for (int i = 0; i < Times.Length; i++)
        {
            if (Times[i] <= 0)
            {
                Times[i] = 0;
            }
            else
            {
                Times[i] -= Time.deltaTime;
                 
            }

        }
	}
}
