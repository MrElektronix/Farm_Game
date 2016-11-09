using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
/// <summary>
/// this class handles the functionality of the nodes in the game;
/// </summary>

public class Node : MonoBehaviour {
    BuildManager buildManager;

    public Color hoverColor;
    public GameObject canvasParent;

    private GameObject _plant;
    private GameObject _button;

    private Renderer _rend;
    private Color _startColor;

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

        if (buildManager.GetSeedToPlant() == null)
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

        if (buildManager.GetSeedToPlant() == null)
        {
            return;
        }

        if (_plant != null)
        {
            Debug.Log("nika");
            return;
        }

        //get a plant from the buildmanager. Instantiate plant.
        GameObject plantToBuild = BuildManager.instance.GetSeedToPlant();
        _plant = (GameObject)Instantiate(plantToBuild, transform.position, transform.rotation);
        Timer timer = _plant.AddComponent<Timer>();
        timer.SetTimer(40);

        //get a button from the buildmanager. Instantiate button
        GameObject buttonToBuild = BuildManager.instance.GetButton();
        _button = (GameObject)Instantiate(buttonToBuild, transform.position, transform.rotation);
        _button.transform.SetParent(canvasParent.transform);
        TimerUI timerui = _button.AddComponent<TimerUI>();

        //give a reference to buttonscript (timerUI) to the timer
        timer.timerButtonText = timerui;



        
       
        



    }

    void OnMouseExit() {
        _rend.material.color = _startColor;
    }
}
