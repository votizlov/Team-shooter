﻿using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameProxy gameProxy;

    [SerializeField] private AttackManager attackManager;
    // Start is called before the first frame update
    void Start()
    {
        gameProxy.attackManager = attackManager;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
