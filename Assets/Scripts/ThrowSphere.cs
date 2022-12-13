using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Logic For throwing the in-hand-sphere
/// 1-throw the sphere
/// 2- if it land inside boxes then OK
/// 3- else it respawns in Hand again(transform reset)
/// </summary>
/// 

public class ThrowSphere : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float projectileSpeed = 5, fireRate = 0.3f;
               
    private Vector3 destination;
    private float timeToFire;


    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= timeToFire)
        {
            timeToFire = Time.time + 1 / fireRate;
            ThrowTheSphere();
            
        }
    }
    void ToggleProjectile() //turn off the in-hand sphere for visual purposes
    {
        projectile.SetActive(true);
    }

    //this method first calculates destination then calls the instantiation method
    void ThrowTheSphere()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(.5f, .5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            destination = hit.point;
        }
        else
        {
            destination = ray.GetPoint(50);
        }
        InstantiateProjectile();
    }


    //instantiating the new sphere to throw like projectile in shooters
    private void InstantiateProjectile()
    {
        var projectileObj = Instantiate(projectile, firePoint.position, cam.transform.rotation);
        projectileObj.transform.localScale = new Vector3(.5f, .5f, .5f);
        Rigidbody rb = projectileObj.GetComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.velocity = (destination - firePoint.position).normalized * projectileSpeed;
        rb.AddForce(0, 20, 0);
        projectile.SetActive(false);
        Invoke(nameof(ToggleProjectile), 3);
        Destroy(projectileObj, 3);
    }
}
