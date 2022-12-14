using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// all public static variables declare here
/// </summary>
/// 
public class StaticVariables : MonoBehaviour
{
    //Bool to check if the Sphere is grabbed or not
    public static bool sphereIsGrabbed = false;

    //Bool to check if we clicked Done Btn on Instrument >> Page canvas UI
    public static bool instrumentPageDone = false;

    //Int to save selected color of Sphere
    public static int selectedSphereColor = 1;

    //Int to determine if sphere is in any box or no >> 0-none/1-boxA/2-boxB/3-boxC
    public static int isSphereHitBox = 0;
}
