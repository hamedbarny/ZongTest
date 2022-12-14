using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// After sphere drops in any box this script determines the Box which is selected
/// </summary>

public class WhichBox : MonoBehaviour
{
    [SerializeField] private GameObject theHand ;
    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Box_A":
                ThisBoxIsHit(1);
                break;
            case "Box_B":
                ThisBoxIsHit(2);
                break;
            case "Box_C":
                ThisBoxIsHit(3);
                break;
        }
    }

    private void ThisBoxIsHit(int box)
    {
        theHand.SetActive(false);
        StaticVariables.isSphereHitBox = box;
    }
}
