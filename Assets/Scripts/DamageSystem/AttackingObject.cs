using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class AttackingObject : MonoBehaviour
{
    [SerializeField] private GameProxy gameProxy;
    public float range;

    public AttackTypes type;

//todo reload logic + attack properties
    public void Attack()
    {
        gameProxy.attackManager.Attack(this);
    }
}