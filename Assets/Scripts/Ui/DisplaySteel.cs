using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Steelcounter : MonoBehaviour
{
    int Resource;
    public TextMeshProUGUI text;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Resource = PlayerStats.Steel;
        text.text = ($"Steel:" + Resource.ToString() +"/100");
    }
}