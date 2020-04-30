using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private AttackingObject attackingObject;
    [SerializeField] private int magCapacity;
    [SerializeField] private int maxInventoryRounds;
    
    public void Reload()
    {
        
    }

    public void Fire()
    {
        attackingObject.Attack();
    }
}
