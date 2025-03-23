using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.MessageBox;

public class PlacementSystem : MonoBehaviour
{
    [SerializeField]
    GameObject gShader, gIndicator, plantpanel;
    [SerializeField]
    private MouseInput MouseInput;

    [SerializeField]
    private Grid grid;
    static public bool PlantingMode;

    [SerializeField]
    private ObjectDatabase database;
    private int selectedObjectIndex = -1;
    private int Manacost;
    private int Woodcost;
    private int Steelcost;

    public bool first;
    private void Start()
    {
        first = true;
        StopBuilding();
       
    }
    public void StartBuilding(int ID)
    {
        StopBuilding();
        selectedObjectIndex = database.objectData.FindIndex(data => data.ID == ID);
        if (selectedObjectIndex < 0)
        {
            Debug.LogError($"No ID found {ID}");
            return;
        }
        gShader.SetActive(true);
        gIndicator.SetActive(true);
        MouseInput.OnClicked += PlaceStructure;
        MouseInput.OnExit += StopBuilding;
    }

    private void PlaceStructure()
    {
        
        
        if (MouseInput.IsPointerOverUI())
        {
            return;
        }
        #region Cost Finding

        Manacost = database.objectData[selectedObjectIndex].Mana_Cost;
        Woodcost = database.objectData[selectedObjectIndex].Wood_Cost;
        Steelcost = database.objectData[selectedObjectIndex].Steel_Cost;
        #endregion
        #region Cost Enforcement
        if (PlayerStats.Mana >= Manacost)
        {
            PlayerStats.Mana -= Manacost;
            
        }
        else 
        {
            Debug.Log("Out of Mana");
            return;
        }

        if (PlayerStats.Wood >= Woodcost)
        {
            PlayerStats.Wood -= Woodcost;

        }
        else
        {
            Debug.Log("Out of Wood");
            return;
        }

        if (PlayerStats.Steel >= Steelcost)
        {
            PlayerStats.Steel -= Steelcost;

        }
        else
        {
            Debug.Log("Out of Steel");
            return;
        }

        #endregion    
        MinValueEnforcer(); ;
        Vector3 MousePos = MouseInput.GetMapPosition();
        Vector3Int gridPosition = grid.WorldToCell(MousePos);
        GameObject structure = Instantiate(database.objectData[selectedObjectIndex].Prefab);
        structure.transform.position = grid.CellToWorld(gridPosition);
        #region Tutorial
        if (first == true)
        {
            MIlestones.MileDict["Crafter"] = true;
            plantpanel.SetActive(false);
            StopBuilding();
            first = false;
        }
        #endregion
    }

    private void StopBuilding()
    {
        selectedObjectIndex = -1;
        gShader.SetActive(false);
        gIndicator.SetActive(false);
        MouseInput.OnClicked -= PlaceStructure;
        MouseInput.OnExit -= StopBuilding;
    }

    private void Update()
    {
        if (selectedObjectIndex < 0)
            return;
        Vector3 MousePos = MouseInput.GetMapPosition();
       
        Vector3Int gridPosition = grid.WorldToCell(MousePos);
        gIndicator.transform.position = grid.CellToWorld(gridPosition);       
    }
    



    public void MinValueEnforcer()
    {
        if (PlayerStats.Mana < PlayerStats.MinMana)
        {
            PlayerStats.Mana = PlayerStats.MinMana;
        }
        if (PlayerStats.Steel < PlayerStats.MinSteel)
        {
            PlayerStats.Steel = PlayerStats.MinSteel;
        }
        if (PlayerStats.Wood < PlayerStats.MinWood)
        {
            PlayerStats.Wood = PlayerStats.MinWood;
        }
    }
}
