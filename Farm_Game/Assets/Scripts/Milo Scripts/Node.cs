using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Node : MonoBehaviour {

    public Color hoverColor;
    public GameObject canvasParent;

    private GameObject _plant;
    private GameObject _time;

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

        GameObject timetoBuild = BuildManager.instance.GetTimerToTime();
        _time = (GameObject)Instantiate(timetoBuild);
        _time.transform.SetParent(canvasParent.transform);


    }

    void OnMouseExit() {
        _rend.material.color = _startColor;
    }
}
