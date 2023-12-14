using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Woodcounter : MonoBehaviour
{
    int Resource;
    public TextMeshProUGUI text;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Resource = PlayerStats.Wood;
        text.text = ($"Wood:" + Resource.ToString() +"/100");
    }
}