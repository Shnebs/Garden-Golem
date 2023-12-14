using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MIlestones : MonoBehaviour
{
    public static IDictionary<string, bool> MileDict = new Dictionary<string, bool>
    {
        {"Nothing",true},
        {"FirstMove", false},
        {"Crafter",false},
        {"Ferrostelm",false},
        {"Storage",false},
        {"Armourer",false},
        {"SteelArmour",false},
        {"Bears",false},
        {"DeadBear",false},
        {"WolfRepellantFound",false},
        {"WisdomStatue",false},
        {"IngenuityStatue",false},
        {"OpeningTutorial",false},
        {"PlantingTutorial",false},
        {"CrafterTutorial",false}
    };

    
    void Start()
    {
        
    }

}
