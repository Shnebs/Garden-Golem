using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSureTutorialDoesntDoubleOpen : MonoBehaviour
{
    public GameObject TutorialBox;
    void Awake()
    {
        Debug.Log("Loaded on Wake");
         if (MIlestones.MileDict["OpeningTutorial"])
        {
            Debug.Log("Text Box Closed");
            TutorialBox.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
