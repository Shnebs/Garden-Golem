using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetectionSystem : MonoBehaviour
{
    public GameObject SetText;
    public GameObject SetTextBox;
    private void OnTriggerEnter(Collider other)
    {
        SetTextBox.SetActive(true);
        SetText.SetActive(true);
    }
}
