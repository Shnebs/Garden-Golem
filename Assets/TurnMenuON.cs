using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnMenuON : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject CraftingMenuA;
    public GameObject CraftingMenuB;
    public GameObject CraftingMenuC;
    public bool MenuOpen;
    // Start is called before the first frame update
    void Start()
    {
        MenuOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !PlacementSystem.PlantingMode && CraftingMenuA.activeInHierarchy == false && CraftingMenuB.activeInHierarchy == false && CraftingMenuC.activeInHierarchy == false && MenuOpen == false)
        {
            mainmenu.SetActive(true);
            MenuOpen = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && MenuOpen == true)
        {
            mainmenu.SetActive(false);
            MenuOpen= false;
        }
    }
}
