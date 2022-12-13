using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Used when The Canvas UI is supposed to be showed
/// it disables player movements and unlocks mouse cursor so we can interact with UI elements via mouse
/// </summary>


public class CanvasUIManager : MonoBehaviour
{

    [SerializeField] GameObject playerController, reticleCanvas;

    private void OnEnable()
    {
        ToggleUIFocus(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    private void OnDisable()
    {
        ToggleUIFocus(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    
    //toggle player Movements and reticle pointer
    private void ToggleUIFocus(bool flag)
    {
        playerController.GetComponent<FirstPersonController>().enabled = flag;
        reticleCanvas.SetActive(flag);
    }
}
