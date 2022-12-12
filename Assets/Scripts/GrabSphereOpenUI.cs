using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabSphereOpenUI : MonoBehaviour
{
    [SerializeField] GameObject theSphere, canvasUI;
    private bool flag = true;
    void Update()
    {
        if (StaticVariables.SphereIsGrabbed && flag)
        {
            theSphere.GetComponent<Animator>().Play("SphereGrabAnim");
            flag = false;
            Invoke(nameof(ToggleCanvasUI), 0.65f);
        }
        if (!StaticVariables.SphereIsGrabbed && !flag)
        {
            theSphere.GetComponent<Animator>().Play("SphereUnGrabAnim");
            flag = true;
            Invoke(nameof(ToggleCanvasUI), 0);
        }
    }

    private void ToggleCanvasUI()
    {
        if (!canvasUI.activeInHierarchy) canvasUI.SetActive(true);
        else if (canvasUI.activeInHierarchy) canvasUI.SetActive(false);
    }
}
