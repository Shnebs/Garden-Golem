using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithObject : MonoBehaviour
{
    private LayerMask layerMask;
    public string MilestoneTrue;
    public string MilestoneFalse;
    public string MilestoneToChange;
    public GameObject textBox;
    public GameObject textforFalse; 
    public GameObject textforTrue;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (!MIlestones.MileDict[MilestoneFalse])
        {
            textBox.SetActive(true);
            textforFalse.SetActive(true);
            Debug.Log("Bear Found befire other bear");

        }
        else if (MIlestones.MileDict[MilestoneTrue])
        {
            textBox.SetActive(true);
            textforTrue.SetActive(true);
            Debug.Log("Bear Found After other bear");
            MIlestones.MileDict[MilestoneToChange] = true;
            gameObject.SetActive(false);
        }
    }
    
                
    
}
