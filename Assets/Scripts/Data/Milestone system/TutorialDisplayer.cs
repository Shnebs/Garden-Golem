using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayafterMilestone : MonoBehaviour
{
    public bool justOnce;
    public string Milestone;
    public GameObject Text;
    public GameObject TextBox;
    // Start is called before the first frame update
    void Start()
    {
        justOnce = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (MIlestones.MileDict[Milestone] && justOnce == false)
        {
            Text.SetActive(true);
            TextBox.SetActive(true);
            justOnce = true;
            return;
        }
    }
}
