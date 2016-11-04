using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour {

    public Color hoverColor;

    private GameObject _plant;

    private Renderer _rend;
    private Color _startColor;

    BuildManager buildManager;

    void Start() {
        _rend = GetComponent<Renderer>();
        _startColor = _rend.material.color;
        buildManager = BuildManager.instance;
    }

    void OnMouseEnter() {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (buildManager.GetPlantToPlant() == null)
        {
            return;
        }
        _rend.material.color = hoverColor;   
    }

    void OnMouseDown() {

        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (buildManager.GetPlantToPlant() == null)
        {
            return;
        }

        if (_plant != null)
        {
            Debug.Log("nika");
            return;
        }

        GameObject plantToBuild = BuildManager.instance.GetPlantToPlant();
        _plant = (GameObject)Instantiate(plantToBuild, transform.position, transform.rotation);
    }

    void OnMouseExit() {
        _rend.material.color = _startColor;
    }
}
