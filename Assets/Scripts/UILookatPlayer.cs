using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Lookat Player Camera
/// </summary>


public class UILookatPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerCamera;
    private void FixedUpdate()
    {
        this.transform.LookAt(playerCamera, Vector3.up);
    }
}
