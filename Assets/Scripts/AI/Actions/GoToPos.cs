using System.Collections;
using System.Collections.Generic;
using Apex.AI;
using UnityEngine;

public class GoToPos : ActionBase
{

    public override void Execute(IAIContext context)
    {
        var c = (MainContext)context;
        c.agent.destination = c.lastOrderedDestination;
    }
}
