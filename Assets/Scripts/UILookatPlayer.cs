using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILookatPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerCamera;
    private void FixedUpdate()
    {
        this.transform.LookAt(playerCamera, Vector3.up);
    }
}
