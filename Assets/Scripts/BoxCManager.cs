using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Reset desiered values and return player to location of cave(Grab sphere stage) 
/// </summary>

public class BoxCManager : MonoBehaviour
{
    [SerializeField] private GameObject thePlayer, CanvasBox, explodeCanvas, canvasUI, logicLevelSphere, UISphere;
    [SerializeField] private Transform levelSphereTrans;

    private void OnEnable()
    {
        Invoke(nameof(ResetToSphereLevel), 3);

    }

    private void ResetToSphereLevel() // values reset here
    {
        thePlayer.transform.position = levelSphereTrans.position;
        thePlayer.transform.rotation = levelSphereTrans.rotation;
        explodeCanvas.SetActive(false);
        CanvasBox.SetActive(false);
        //canvasUI.SetActive(true);
        logicLevelSphere.SetActive(true);
        StaticVariables.instrumentPageDone = false;
        StaticVariables.sphereIsGrabbed = true;
        this.gameObject.SetActive(false);
    }
}
