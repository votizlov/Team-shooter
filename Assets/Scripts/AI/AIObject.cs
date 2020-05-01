using System.Collections;
using System.Collections.Generic;
using AI;
using UnityEngine;
using UnityEngine.AI;

public class AIObject : MonoBehaviour
{
    [HideInInspector] public BehaviorStates state;
    public NavMeshAgent agent;

    [SerializeField] private AnimatorControllerParameter animatorControllerParameter;


    public Transform target;

    void Awake()
    {
        BehaviorsController.UpdateBehavior(this);
    }

    void Update()
    {
    }
}