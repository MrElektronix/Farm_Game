using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class plantPlacement : MonoBehaviour {

    private void OnMouseOver()
    {


        if (!EventSystem.current.IsPointerOverGameObject() && gameManager.Instance.clickedBTN != null)
        {

            if (Input.GetMouseButtonDown(0))
            {
                PlaceTower();
            }
        }

    }
    private void PlaceTower()
    {

        GameObject tower = (GameObject)Instantiate(gameManager.Instance.clickedBTN.PlantPrefab, transform.position, Quaternion.identity);
        //tower.GetComponent<SpriteRenderer>().sortingOrder = GridPosition.Y;

        //tower.transform.SetParent(transform);


        gameManager.Instance.BuyPlant();

    }
}
