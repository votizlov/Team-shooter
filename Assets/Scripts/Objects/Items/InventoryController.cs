using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public Gun currentGun;
    [SerializeField] private List<Gun> guns;
    [SerializeField] private Transform gunPlace;

    public void Awake()
    {
        //todo инстанцирование пушек
        Gun gun = Instantiate(currentGun, gunPlace.position, gunPlace.rotation);
        gun.transform.SetParent(gunPlace);
    }

    public void FireCurrentGun()
    {
        currentGun.Fire();
    }

    public void ReloadCurrentGun()
    {
        
    }

    public void AddGun()
    {
        
    }

    public void AddRounds()
    {
        
    }
}
