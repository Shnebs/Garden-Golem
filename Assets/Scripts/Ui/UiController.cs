using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{
    public GameObject BuildingMenu;
    public GameObject PlantMenu, ferrostelmButton;
    public GameObject PlaceableBuildingMenu, crafterButton, storageButton;
    // Start is called before the first frame update
    void Start()
    {
        CloseMenu();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CloseMenu();
        }
    }

    public void OpenPlantMenu()
    {
        PlantMenu.SetActive(true);
        ferrostelmButton.SetActive(true);
        BuildingMenu.SetActive(false);
    }

    public void OpenBuildMenu() 
    {
        PlaceableBuildingMenu.SetActive(true);
        crafterButton.SetActive(true);
        storageButton.SetActive(true);
        BuildingMenu.SetActive(false);
    }

    public void CloseMenu() 
    {
        PlaceableBuildingMenu.SetActive(false);
        PlantMenu.SetActive(false);
        gameObject.SetActive(false);
    }
}
