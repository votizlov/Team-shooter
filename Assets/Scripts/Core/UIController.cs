using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject alliesShop;
    [SerializeField] private GameObject alliesMenu;
    private AlliesShop _currShop;
    private AlliesCommander _currCommander;

    private bool _isMenuOpened;

    public void OpenAlliesShopMenu(AlliesShop shop)
    {
        if (_isMenuOpened) return;
        _isMenuOpened = true;
        _currShop = shop;
        alliesShop.SetActive(true);
    }

    public void OpenAlliesMenu(AlliesCommander commander)
    {
        if (_isMenuOpened) return;
        _isMenuOpened = true;
        _currCommander = commander;
        alliesMenu.SetActive(true);
    }

    public void SpawnBoughtAlly(GameObject ally)
    {
        alliesShop.SetActive(false);
        _isMenuOpened = false;
        Instantiate(ally, _currShop.spawnPoint, Quaternion.identity);
    }

    public void ChangeAllyBehavior(AllyBehaviors behavior)
    {
        _currCommander.allyBehavior = behavior;
        alliesMenu.SetActive(false);
        _isMenuOpened = false;
    }

    public void ChangeAllyDestination()
    {
        _currCommander.UpdateDestination();
        alliesMenu.SetActive(false);
        _isMenuOpened = false;
    }

    public void ChangeAllyTarget()
    {
        _currCommander.UpdateTarget();
        alliesMenu.SetActive(false);
        _isMenuOpened = false;
    }
}
