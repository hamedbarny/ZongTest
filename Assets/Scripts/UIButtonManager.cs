using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject pageWeapone, pagePoint, pageInstrument;
    public void ButtonX()
    {
        StaticVariables.SphereIsGrabbed = false;
    }
    public void ButtonWeapone()
    {
        togglePages(1);
    }
    public void ButtonPoint()
    {
        togglePages(2);
    }
    public void ButtonInstrument()
    {
        togglePages(3);
    }

    private void togglePages(int page)
    {
        switch (page){
            case 1:
                pageWeapone.SetActive(true);
                pagePoint.SetActive(false);
                pageInstrument.SetActive(false);
                break;
            case 2:
                pageWeapone.SetActive(false);
                pagePoint.SetActive(true);
                pageInstrument.SetActive(false);
                break;
            case 3:
                pageWeapone.SetActive(false);
                pagePoint.SetActive(false);
                pageInstrument.SetActive(true);
                break;
        }
    }
}
