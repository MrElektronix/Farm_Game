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
        Debug.Log(PlantBtn.Sprite);
       // SpriteRenderer sr = Hover.Instance.spriteRenderer;
        Hover.Instance.Activate(PlantBtn.Sprite);
    }

    public void BuyPlant()
    {
        //Debug.Log(Hover.Instance);

     //   SpriteRenderer sr = Hover.Instance.spriteRenderer;
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
