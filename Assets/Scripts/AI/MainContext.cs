using System.Collections;
using System.Collections.Generic;
using Apex.AI;
using UnityEngine;
using UnityEngine.AI;

public class MainContext : IAIContext
{
    public List<GameObject> possibleTargets;
    public NavMeshAgent agent;
    public Gun gun;
    public GameObject target;
    public Transform currentPos;
    public Vector3 targetPosition;
    public Vector3 lastOrderedDestination;
    public PlayerController currPlayer;
    public AlliesCommander commander;
}
