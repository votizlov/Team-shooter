using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI
{
    public static class BehaviorsController
    {
        public static void UpdateBehavior(AIObject aiObject)
        {
            switch (aiObject.state)
            {
                case BehaviorStates.Idle:Idle(aiObject)
                    ;
                    break;
                case BehaviorStates.Attacking:
                    ;
                    break;
                case BehaviorStates.Patrolling:
                    ;
                    break;
                case BehaviorStates.Pirsuing:
                    ;
                    break;
                default:
                    Debug.LogError("Undefined state");
                    break;
            }
        }

        private static void Idle(AIObject aiObject)
        {
            aiObject.agent.SetDestination(aiObject.target.position);
        }
        
        private static void Attacking(AIObject aiObject){
    
        }
        private static void Patrolling(AIObject aiObject){
    
        }
        private static void Pirsuing(AIObject aiObject){
    
        }
    }


    public enum BehaviorStates
    {
        Idle,
        Patrolling,
        Pirsuing,
        Attacking
    }
}