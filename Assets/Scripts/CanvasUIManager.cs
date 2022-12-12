using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private void ToggleUIFocus(bool flag)
    {
        playerController.GetComponent<FirstPersonController>().enabled = flag;
        reticleCanvas.SetActive(flag);
    }
}
