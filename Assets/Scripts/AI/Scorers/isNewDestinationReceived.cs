using System.Collections;
using System.Collections.Generic;
using Apex.AI;
using UnityEngine;

public class isNewDestinationReceived : ContextualScorerBase
{

    public override float Score(IAIContext context)
    {
        var c = (MainContext)context;
        if (c.lastOrderedDestination != c.commander.AlliesDestination)
        {
            c.lastOrderedDestination = c.commander.AlliesDestination;
            return 3;
        }

        return 0;
    }
}
