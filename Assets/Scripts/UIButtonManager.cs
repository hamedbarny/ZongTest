using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Methods used in Canvas UI buttons to change between different pages
/// </summary>


public class UIButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject pageWeapone, pagePoint, pageInstrument , UISphere;
    [SerializeField] private MeshRenderer innerSphereMesh;
    [SerializeField] private Light sphereLight;


    //This block is for Main canvas btn methods
    #region  Main Btns
    public void ButtonX() //quit btn
    {
        togglePages(0);
    }
    public void ButtonWeapone() //Weapone btn
    {
        togglePages(1);
    }
    public void ButtonPoint() //Point btn
    {
        togglePages(2);
    }
    public void ButtonInstrument() //Instrument btn
    {
        togglePages(3);
    }
    
    //toggles between pages of Canvas UI
    private void togglePages(int page)
    {
        switch (page) {
            case 0: //Quiet UI + reset Page
                StaticVariables.sphereIsGrabbed = false;
                pageWeapone.SetActive(false);
                pagePoint.SetActive(true);
                pageInstrument.SetActive(false);
                break;
            case 1: //show weapone page
                pageWeapone.SetActive(true);
                pagePoint.SetActive(false);
                pageInstrument.SetActive(false);
                break;
            case 2: //show Point && Default page
                pageWeapone.SetActive(false);
                pagePoint.SetActive(true);
                pageInstrument.SetActive(false);
                break;
            case 3: //show Instrument page
                pageWeapone.SetActive(false);
                pagePoint.SetActive(false);
                pageInstrument.SetActive(true);
                break;
        }
    }
    #endregion


    // This Block is for Instrument Page Button methods
    #region Instrument Page Btn

    public void BtnDone()
    {
        StaticVariables.instrumentPageDone = true;
        UISphere.GetComponent<Animator>().Play("SphereUIExplodeAnim");
    }
     public void BtnColorChanger_1() //RED
    {
        ToggleColors(1);
    }
    public void BtnColorChanger_2() //Gold
    {
        ToggleColors(2);
    }
    public void BtnColorChanger_3() //Green
    {
        ToggleColors(3);
    }
    public void BtnColorChanger_4() //Cyan
    {
        ToggleColors(4);
    }
    public void BtnColorChanger_5() //Blue
    {
        ToggleColors(5);
    }

    // switch between Sphere various colors
    private void ToggleColors(int colorNumber)
    {
        StaticVariables.selectedSphereColor = colorNumber;
        switch (colorNumber)
        {
            case 1:
                innerSphereMesh.material.SetColor("_EmissionColor", Color.red);
                sphereLight.color = Color.red;
                break;
            case 2:
                innerSphereMesh.material.SetColor("_EmissionColor", Color.yellow);
                sphereLight.color = Color.yellow;
                break;
            case 3:
                innerSphereMesh.material.SetColor("_EmissionColor", Color.green);
                sphereLight.color = Color.green;
                break;
            case 4:
                innerSphereMesh.material.SetColor("_EmissionColor", Color.cyan);
                sphereLight.color = Color.cyan;
                break;
            case 5:
                innerSphereMesh.material.SetColor("_EmissionColor", Color.blue);
                sphereLight.color = Color.blue;
                break;

        }
    }

    #endregion
}
