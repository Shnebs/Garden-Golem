using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialougeup : MonoBehaviour
{
    public string MilestoneToSetFalse;
    public string MilestoneToSetTrue;
    static public bool talking;
    public bool showtalking;
    public GameObject TextBox;
    public TextMeshProUGUI TextComp;
    public string[] dialouge;
    public float TxtSpd;

    private int index;
    void Start()
    {
        talking = false;
        TextComp.text = string.Empty;
        StartDialouge();

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetButtonDown("Fire1"))
        {
            if(TextComp.text == dialouge[index])
            {
                nextLine();
            }
            else
            {               
                StopAllCoroutines();
                TextComp.text = dialouge[index];
            }
        }
    }

    void StartDialouge()
    {
        talking = true;
        StartCoroutine(TypeLine());
    }
    
    IEnumerator TypeLine()
    {
        foreach (char c in dialouge[index].ToCharArray()) 
        {
            TextComp.text += c;
            yield return new WaitForSeconds(TxtSpd); 
        }
    }

    void nextLine()
    {
        if (index < dialouge.Length - 1)
        {
            index++;
            TextComp.text = string.Empty;
            StartCoroutine (TypeLine());
        }
        else
        {
            talking = false;
            Debug.Log("text stopped");
            gameObject.SetActive(false);
            TextBox.SetActive(false);
            MIlestones.MileDict[MilestoneToSetFalse] = false;
            MIlestones.MileDict[MilestoneToSetTrue] = true;
        }
    }
}
