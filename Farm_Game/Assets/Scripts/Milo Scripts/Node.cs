using UnityEngine;
using System.Collections;

public class Node : MonoBehaviour {

    public Color hoverColor;

    private GameObject _plant;

    private Renderer _rend;
    private Color _startColor;

    void Start() {
        _rend = GetComponent<Renderer>();
        _startColor = _rend.material.color;
    }

    void OnMouseEnter() {
        _rend.material.color = hoverColor;   
    }

    void OnMouseDown() {
        if (_plant != null)
        {
            Debug.Log("nika");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetPlantToPlant();
        _plant = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);
    }

    void OnMouseExit() {
        _rend.material.color = _startColor;
    }
}
