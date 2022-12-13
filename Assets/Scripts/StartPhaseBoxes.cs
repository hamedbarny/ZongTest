using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Phase Boxes begin after sphere is selected in Canvas main UI instument page
/// 
/// enables hand + sphere in it
/// change sphere color regarding selected color before
/// and officialy begin the phase boxes
/// </summary>

public class StartPhaseBoxes : MonoBehaviour
{
    [SerializeField] private GameObject explodeCanvas, thePlayer, logicLevel1, theHand , reticle;
    [SerializeField] private MeshRenderer sphereOnHandInner;
    [SerializeField] private Light sphereOnHandLight;
    [SerializeField] private Transform locationLevel2;

    private bool flag = true;

    void Update()
    {
         //whenever button on instrument page >> canvas UI is clicked
        if (StaticVariables.instrumentPageDone && flag) 
        {
            Invoke(nameof(ChangePhaseToBoxes), 1.5f); //wait time for FORGE/Explode animation
            flag = false;
        } 
    }

    public void ChangePhaseToBoxes()
    {
        StaticVariables.instrumentPageDone = false; //reset the static variable
        explodeCanvas.SetActive(true);  //simple explosion light visuals
        Invoke(nameof(PhaseBoxBegin), 1f);
        StaticVariables.sphereIsGrabbed = false; //reset the static variable

    }

    private void PhaseBoxBegin()
    {
        ChangeSphereInHandColor(StaticVariables.selectedSphereColor); //change color hand sphere according to selected one
        reticle.SetActive(false); // deactivate reticle pointer
        logicLevel1.SetActive(false); // deacvtivate prev lvl that we dont need anymore
        theHand.SetActive(true); //hand enable
        explodeCanvas.SetActive(false); 
    }

    //Method for Change color of In-Hand Sphere regarding selected one
    private void ChangeSphereInHandColor(int colorNumber)
    {
        switch (colorNumber)
        {
            case 1:
                sphereOnHandInner.material.SetColor("_EmissionColor", Color.red);
                sphereOnHandLight.color = Color.red;
                break;
            case 2:
                sphereOnHandInner.material.SetColor("_EmissionColor", Color.yellow);
                sphereOnHandLight.color = Color.yellow;
                break;
            case 3:
                sphereOnHandInner.material.SetColor("_EmissionColor", Color.green);
                sphereOnHandLight.color = Color.green;
                break;
            case 4:
                sphereOnHandInner.material.SetColor("_EmissionColor", Color.cyan);
                sphereOnHandLight.color = Color.cyan;
                break;
            case 5:
                sphereOnHandInner.material.SetColor("_EmissionColor", Color.blue);
                sphereOnHandLight.color = Color.blue;
                break;
        }
    }
}
