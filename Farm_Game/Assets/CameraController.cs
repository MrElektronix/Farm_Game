using UnityEngine;


public class CameraController : MonoBehaviour {

    private float _panSpeed = 8f;

	// Update is called once per frame
	void Update () {
	    if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * _panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * _panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * _panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * _panSpeed * Time.deltaTime, Space.World);
        }
    }
}
