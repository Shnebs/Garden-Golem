using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseInput : MonoBehaviour
{
   
    [SerializeField]
    private Camera MainCamera;

    private Vector3 LastPos;

    [SerializeField]

    public event Action OnClicked, OnExit;

    [SerializeField]
    private LayerMask placeLayerMask;

    private void Update()
    {
        if (Input.GetButtonDown("Fire2"))
            OnClicked?.Invoke();
        if(Input.GetKeyDown(KeyCode.Escape))
            OnExit?.Invoke();
    }

    public bool IsPointerOverUI()
        => EventSystem.current.IsPointerOverGameObject();

    public Vector3 GetMapPosition()
    {
        Vector3 MousePos = Input.mousePosition;
        MousePos.z = MainCamera.nearClipPlane;
        Ray ray = MainCamera.ScreenPointToRay(MousePos);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100, placeLayerMask))
        {
            LastPos = hit.point;
        }
        return LastPos;
    }
}
