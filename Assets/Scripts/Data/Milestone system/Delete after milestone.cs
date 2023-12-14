using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilestoneDeforcer : MonoBehaviour
{
    public string Milestone;

    void Update()
    {
        ChecksFunction();
    }

    public void ChecksFunction()
    {
        if (MIlestones.MileDict[Milestone])
        {
            gameObject.SetActive(false);
            return;
        }
    }
}
