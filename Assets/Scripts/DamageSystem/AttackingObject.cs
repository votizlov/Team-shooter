using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class AttackingObject : MonoBehaviour
{
    [SerializeField]private GameProxy gameProxy; 
    public AttackTypes type;

    public void Attack()
    {
        gameProxy.attackManager.Attack(this);
    }
}
