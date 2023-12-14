using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantGrowth : MonoBehaviour
{
    [SerializeField]
    public string PlantName;
    public float GrowthTime;
    public bool Growing = false;
    private float GrowthRate;
    // Start is called before the first frame update
    private void Awake()
    {
        transform.gameObject.tag = "BabyPlant";
        Growing = true;
        GrowthRate = (0.75f / GrowthTime) / 50f;
        transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
    }
    private void FixedUpdate()
    {
        if (Growing)
        {
            transform.localScale += new Vector3(GrowthRate, GrowthRate, GrowthRate);
        }
        
    }
    private void Update()
    {
        if (Growing)
        {
            if (GrowthTime > 0)
            {
                GrowthTime -= Time.deltaTime;

            }
            else
            { 
                Debug.Log("Growth Finished");
                transform.gameObject.tag = PlantName;
                Growing=false;
            }
        }
    }
}
