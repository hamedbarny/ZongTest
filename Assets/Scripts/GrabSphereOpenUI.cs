using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Enable/Disable Canvas UI whenever public static variable SphereIsGrabbed Changes
/// </summary>


public class GrabSphereOpenUI : MonoBehaviour
{

    [SerializeField] private GameObject canvasUI;
    [SerializeField] private Animator sphereAnimator;
    private bool flag = true;

    private void Update()
    {
        if (StaticVariables.sphereIsGrabbed && flag)
        {
            sphereAnimator.Play("SphereGrabAnim");
            Invoke(nameof(ToggleCanvasUI), 0.1f);
            flag = false;
        }
        if (!StaticVariables.sphereIsGrabbed && !flag)
        {
            sphereAnimator.Play("SphereUnGrabAnim");
            Invoke(nameof(ToggleCanvasUI), 0);
            flag = true;
        }
    }

    // method for Enable/Disable Canvas UI
    private void ToggleCanvasUI()
    {
        if (!canvasUI.activeInHierarchy) canvasUI.SetActive(true);
        else if (canvasUI.activeInHierarchy) canvasUI.SetActive(false);
    }
}
