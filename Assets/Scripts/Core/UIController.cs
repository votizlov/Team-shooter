using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject alliesShop;
    [SerializeField] private GameObject alliesMenu;
    private AlliesShop _currShop;

    private bool _isMenuOpened;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenAlliesShopMenu(AlliesShop shop)
    {
        if (_isMenuOpened) return;
        _isMenuOpened = true;
        _currShop = shop;
        alliesShop.SetActive(true);
    }

    public void OpenAlliesMenu(PlayerController player)
    {
        if (_isMenuOpened) return;
        _isMenuOpened = true;
        alliesMenu.SetActive(true);
    }

    public void SpawnBoughtAlly(GameObject ally)
    {
        alliesMenu.SetActive(false);
        _isMenuOpened = false;
        Instantiate(ally, _currShop.spawnPoint, Quaternion.identity);
    }
}
