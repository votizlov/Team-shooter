using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class AttackingObject : MonoBehaviour
{
    public float range, damage, speed, reload;
    [SerializeField] private GameProxy gameProxy;

    private bool isReloading = false;
    public AttackTypes type;

//todo reload logic + attack properties
    public void Attack()
    {
        if (isReloading) return;
        gameProxy.attackManager.Attack(this);
        StartCoroutine(Reloading());
    }
    
    private IEnumerator Reloading()
    {
        isReloading = true;
        yield return new WaitForSeconds(reload);
        isReloading = false;
    }

}