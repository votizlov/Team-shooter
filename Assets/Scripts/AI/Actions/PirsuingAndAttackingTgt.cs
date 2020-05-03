using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class PirsuingAndAttackingTgt : StateMachineBehaviour
{
    public AIObject ai;

    private float range;

    private GameObject closest;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        ai = animator.GetComponent<AIObject>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        range = ai.attack.attackingObject.range;
        foreach (var tgt in ai.possibleTargets)
        {
            Debug.Log(tgt);
            if (Vector3.Distance(ai.transform.position, tgt.transform.position) < range)
            {
                closest = tgt;
                range = Vector3.Distance(ai.transform.position, tgt.transform.position);
            }
        } 
        if (range < ai.attack.attackingObject.range)
            ai.agent.SetDestination(closest.transform.position);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}