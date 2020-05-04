using System.Collections;
using System.Collections.Generic;
using Apex.AI;
using UnityEngine;

public class FollowPlayer : ActionBase
{

    public override void Execute(IAIContext context)
    {
        var c = (MainContext) context;
        c.targetPosition = c.currPlayer.gameObject.transform.position;
        c.agent.stoppingDistance = 2;
        c.agent.SetDestination(c.targetPosition);
    }
}
