using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableMilestone : MonoBehaviour
{
    public string Milestone;
    void Start()
    {
        MIlestones.MileDict[Milestone] = true;
        Debug.Log($"{Milestone} set true");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
