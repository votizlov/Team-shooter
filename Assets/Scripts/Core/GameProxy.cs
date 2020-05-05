using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    [CreateAssetMenu(menuName = "ScriptableObjects/GameProxy", order = 2)]
    public class GameProxy : ScriptableObject
    {
        public List<GameObject> allies = new List<GameObject>();
        public List<GameObject> enemies = new List<GameObject>();
        public AttackManager attackManager;
        public PlayerController player;
        public UIController UI;
        public AlliesCommander commander;
        public int currency;
    }
}