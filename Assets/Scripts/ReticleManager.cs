using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Main function is to change reticle visual whenever it is targetting an INTERACTABLE object
/// *********
/// Checks if the interactable object is Aimed + Clicked and then change the variable regarding the object
/// in this example we change the Bool of SphereIsGrabbed so we can Enable/Disable Canvas UI in GrabSphereOpenUI Script regarding the value
/// </summary>

public class ReticleManager : MonoBehaviour
{

    [SerializeField] private Camera Cam;
    [SerializeField] private GameObject crosshairOpen, crosshairClose, canvasUI;
  
    private bool canInteract = false;

    private void Update()
    {
        ReticleChanger();

        //to open Canvas UI 
        if (canInteract && Input.GetMouseButton(0)) StartInteract(true);
        //to close the Canvas UI For DevsOnly **** Remove Before Release
        if (canvasUI.activeInHierarchy && Input.GetKey(KeyCode.Q)) StartInteract(false);
    }

    private void StartInteract(bool isInteractable)
    {
        StaticVariables.sphereIsGrabbed = isInteractable;
    }

    //Method to Change Reticle Visual on INTERACTABLE objects (They are in Layer #6)
    void ReticleChanger() 
    {
        RaycastHit hit;
      
        if (Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hit)) 
        {
            //check layer and distance of the hit object
            if (hit.collider.gameObject.layer == 6 && hit.distance<6) 
            {
                canInteract = true;
                crosshairOpen.SetActive(true);
                crosshairClose.SetActive(false);
            }
            if (hit.collider.gameObject.layer != 6 || hit.distance>=6) 
            {
                canInteract = false;
                crosshairClose.SetActive(true);
                crosshairOpen.SetActive(false);
            }

        }
    }
}
