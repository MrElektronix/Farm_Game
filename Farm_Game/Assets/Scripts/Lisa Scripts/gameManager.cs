using UnityEngine;
using System.Collections;

public class gameManager : Singleton<gameManager>
{

    public plantBTN clickedBTN { get; set; }

    // Update is called once per frame
    void Update()
    {
        HandleEscape();
    }

    public void pickPlant(plantBTN PlantBtn)
    {
        this.clickedBTN = PlantBtn;
        Hover.Instance.Activate(PlantBtn.Sprite);
    }

    public void BuyPlant()
    {
        Hover.Instance.Deactivate();
    }

    private void HandleEscape()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Hover.Instance.Deactivate();
        }
    }
}
