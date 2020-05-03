using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIObject : MonoBehaviour
{
    public List<GameObject> possibleTargets;
    public NavMeshAgent agent;
    public Gun attack;

    private void Start()
    {
        
    }
}