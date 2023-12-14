using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchedKillBox : MonoBehaviour
{
    public string Dead = "Loss";
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(Dead);
    }
}

