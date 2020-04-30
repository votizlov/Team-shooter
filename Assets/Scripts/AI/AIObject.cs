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

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        BehaviorsController.UpdateBehavior(this);
    }
}