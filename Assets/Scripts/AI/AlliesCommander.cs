using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlliesCommander : MonoBehaviour
{
    public AllyBehaviors allyBehavior = AllyBehaviors.Attacking;
    public Vector3 AlliesDestination;
    public GameObject AlliesTarget;
    public Camera cam;

    private RaycastHit _hit;
    private int layerMask = 1 << 9;

    public void UpdateDestination()
    {
        if (Physics.Raycast(transform.position, cam.transform.forward, out _hit, 100,
            ~layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * _hit.distance,
                Color.yellow);
            Debug.Log("Did Hit");
            AlliesDestination = _hit.point;
        }
        else
        {
            Debug.DrawRay(transform.position, cam.transform.forward * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }

    public void UpdateTarget()
    {
    }
}