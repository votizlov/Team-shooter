using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    public GameObject pistolShotEffect;

    public void Attack(AttackingObject attackingObject)
    {
        Debug.Log(attackingObject.transform);
        switch (attackingObject.type)
        {
            case AttackTypes.PistolShot:
                GameObject.Instantiate(pistolShotEffect, new Vector3(0, 0, 0), attackingObject.transform.rotation,
                    attackingObject.transform);
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