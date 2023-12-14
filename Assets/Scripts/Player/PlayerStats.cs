using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    private LayerMask layerMask;
    

    [Header("Health")]
    public int Health;
    static public int MaxHealth = 100;
    static public int MinHealth = 0;

    [Header("Hidden Resources")]
    static public int Mana;
    static public int MaxMana = 100;
    static public int MinMana = 0;
    static public int Wood;
    static public int MaxWood = 100;
    static public int MinWood = 0;
    static public int Steel;
    static public int MaxSteel = 100;
    static public int MinSteel = 0;

    [Header("Shown Resources")]
    public int ManaDisplay;
    public int SteelDisplay;
    public int WoodDisplay;
       
    [Header("Plant Name Tags")]
    public string WoodPlantName;
    public string SteelPlantName;

    private void Start()
    {
        Mana = 1;
        
    }
    public void Update()
    {
        ManaDisplay = Mana;
        SteelDisplay = Steel;
        WoodDisplay = Wood;

        if (Input.GetButtonDown("Fire2"))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 999f,layerMask))
            {  
                if (hit.transform.CompareTag(WoodPlantName))
                {
                    Debug.Log("Plant Found");
                    HarvestSeeds();
                    HarvestWood();
                    Destroy(hit.collider.gameObject);
                }
                else if (hit.transform.CompareTag(SteelPlantName))
                {
                    Debug.Log("Plant Found");
                    HarvestSeeds();
                    HarvestSeeds();
                    HarvestSteel();
                    Destroy(hit.collider.gameObject);
                }
            }

        }
    }
    public void HarvestSeeds()
    {
        
        if (Mana < MaxMana)
        {
            Mana = Mana + Random.Range(1, 4);
        }
        else
        {

        }
    }

    public void HarvestSteel()
    {
        if (Steel < MaxSteel)
        {
            Steel += Random.Range(5, 10);
        }
        else
        {

        }
    }

    public void HarvestWood()
    {
        if (Wood < MaxWood)
        {
            Wood = Wood + Random.Range(6, 12);
        }
        else
        {

        }
    }
}
