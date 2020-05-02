using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    public GameObject pistolShotEffect;
    private Transform t;

    public void Attack(AttackingObject attackingObject)
    {
        switch (attackingObject.type)
        {
            case AttackTypes.PistolShot:
                t = attackingObject.transform;
                GameObject.Instantiate(pistolShotEffect, t.position, t.rotation,
                    t);
                RaycastHit hit;
                Physics.Raycast(attackingObject.transform.position, attackingObject.transform.forward, out hit,
                    attackingObject.range);
                break;
            default:
                Debug.LogError("Undefined attack");
                break;
        }
    }
}