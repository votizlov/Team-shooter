using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class AlliesShop : MonoBehaviour
{
    [SerializeField] private GameProxy gameProxy;
    public Vector3 spawnPoint;
    private bool _isPlayerInRange;

    // Start is called before the first frame update
    private void Start()
    {
        gameProxy.player.OnInteract += OpenMenu;
    }

    // Update is called once per frame
    private void OnDisable()
    {
        gameProxy.player.OnInteract -= OpenMenu;
    }

    private void OpenMenu(PlayerController player)
    {
        if (_isPlayerInRange)
        {
            gameProxy.UI.OpenAlliesShopMenu(this);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            _isPlayerInRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            _isPlayerInRange = false;
    }
}