using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Manacounter : MonoBehaviour
{
    int Resource;
    public TextMeshProUGUI text;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Resource = PlayerStats.Mana;
        text.text = ($"Mana:" + Resource.ToString() +"/100");
    }
}