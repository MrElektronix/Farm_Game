using UnityEngine;
/// <summary>
/// this class puts the different times in an array and counts down until it reaches 0;
/// </summary>

public class PlantTimers : MonoBehaviour {

    public float[] Times;

    // Update is called once per frame
    void Update ()
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
