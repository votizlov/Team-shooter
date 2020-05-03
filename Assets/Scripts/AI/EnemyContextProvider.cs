using System;
using System.Collections;
using System.Collections.Generic;
using Apex.AI;
using Apex.AI.Components;
using Core;
using UnityEngine;
using UnityEngine.AI;

public class EnemyContextProvider : MonoBehaviour, IContextProvider
{
    [SerializeField] private GameProxy gameProxy;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Gun gun;
    private MainContext _context;

    private void Awake()
    {
        _context = new MainContext {agent = agent, possibleTargets = gameProxy.allies, gun = gun,currentPos = transform};
    }

    public IAIContext GetContext(Guid aiId)
    {
        return _context;
    }
}
