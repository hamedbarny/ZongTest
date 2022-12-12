using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReticleManager : MonoBehaviour
{
    [SerializeField] private Camera Cam;
    [SerializeField] private GameObject crosshairOpen, crosshairClose, canvasUI;
  
    private bool canInteract = false;

    private void Update()
    {
        ReticleChanger();
        if (canInteract && Input.GetMouseButton(0)) StartInteract();
        if (canvasUI.activeInHierarchy && Input.GetKey(KeyCode.Q)) StaticVariables.SphereIsGrabbed = false;
    }

    private void StartInteract()
    {
        StaticVariables.SphereIsGrabbed = true;
    }

    void ReticleChanger()
    {
        RaycastHit hit;
      
        if (Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hit)) 
        {
            if (hit.collider.gameObject.layer != 6)
            {
                canInteract = false;
                crosshairClose.SetActive(true);
                crosshairOpen.SetActive(false);
            }
            if (hit.collider.gameObject.layer == 6 && hit.distance<6)
            {
                canInteract = true;
                crosshairOpen.SetActive(true);
                crosshairClose.SetActive(false);
            }

        }
    }
}
