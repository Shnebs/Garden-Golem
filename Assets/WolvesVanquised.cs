using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WolvesVanquised : MonoBehaviour
{
    public GameObject Text;
    public GameObject TextBox;
    private void OnTriggerEnter(Collider other)
    {
        if (MIlestones.MileDict["DeadBear"])
        {
            TextBox.SetActive(true);
            Text.SetActive(true);
            gameObject.SetActive(false);
        }


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
