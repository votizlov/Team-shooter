using System.Collections.Generic;
using AI;
using Objects;
using UnityEngine;

namespace Core
{
    [CreateAssetMenu(menuName = "ScriptableObjects/GameProxy", order = 2)]
    public class GameProxy : ScriptableObject
    {
        public List<GameObject> allies;
        public List<GameObject> enemies;
        public AttackManager attackManager;
        public PlayerController player;
        public UIController UI;
        public AlliesCommander commander;
        public int currency;
    }
}