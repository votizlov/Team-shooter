using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    [SerializeField]static GameObject pistolShotEffect;
    public void Attack(AttackingObject attackingObject)
    {
        switch (attackingObject.type)
        {
            case AttackTypes.PistolShot: GameObject.Instantiate(pistolShotEffect,attackingObject.transform.position,Quaternion.identity);
                break;
            default: Debug.LogError("Undefined attack");
                break;
        }
    }
}
