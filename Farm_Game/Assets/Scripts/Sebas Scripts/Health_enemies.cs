using UnityEngine;
using System.Collections;

public class Health_enemies : MonoBehaviour
{
    public GameObject objectToDestroy;

    void OnMouseDown()
    {
        Destroy(objectToDestroy);
    }
}