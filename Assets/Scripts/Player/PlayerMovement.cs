using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    //NavMeshAgent is necessary to make the player move
    NavMeshAgent player;
    public GameObject BuildMenu;
    public GameObject PlantMenu;
    public GameObject StructureMenu;
    // initialising Ray-cast hit and Ray here saves the PC from creating them every time the player right clicks
    public RaycastHit hit;
    public Ray ray;
    public bool FirstMove;

    [SerializeField]
    private LayerMask placeLayerMask;

    private void Start()
    {
        FirstMove = true;
        player = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.B) && (Dialougeup.talking == false)) 
        { 
            BuildMenu.SetActive(true);
            PlantMenu.SetActive(false);
            StructureMenu.SetActive(false);

        }
        if(Input.GetKeyDown(KeyCode.Escape) && (PlantMenu.activeInHierarchy == true) | (StructureMenu.activeInHierarchy == true)) 
        { 
            PlantMenu.SetActive(false);
            StructureMenu.SetActive(false);
        }
       Move();      
    }

    public void Move()
    {    
        if (Input.GetButtonDown("Fire1") && (Dialougeup.talking == false))
        {
            Debug.Log("moveing");
            // having these inside the if statement stops it from shooting a ray-cast every update, regardless of if its necessary
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //this sets the players destination to where the ray hit AKA where the mouse is pointing
            if (Physics.Raycast(ray, out hit, 999f, placeLayerMask))
            {
                player.destination = hit.point;
               
            }
            if (FirstMove && (Dialougeup.talking == false))
            {
                MIlestones.MileDict["FirstMove"] = true;
                FirstMove = false;
                Debug.Log("First Move Check");
            }

        }
    }
}
