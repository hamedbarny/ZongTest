using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// all public static variables declare here
/// </summary>
/// 
public class StaticVariables : MonoBehaviour
{
    // bool to check if the Sphere is grabbed or not
    public static bool sphereIsGrabbed = false;

    //bool to check if we clicked Done Btn on Instrument >> Page canvas UI
    public static bool instrumentPageDone = false;

    //bool to save selected color of Sphere
    public static int selectedSphereColor = 1;
}
