using System.Collections.Generic;
using AI;
using Objects;
using UnityEngine;

namespace Core
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private GameProxy gameProxy;

        [SerializeField] private AttackManager attackManager;

        [SerializeField] private PlayerController currentplayer;

        [SerializeField] private UIController UI;

        [SerializeField] private AlliesCommander commander;

        void Awake()
        {
            gameProxy.commander = commander;
            gameProxy.attackManager = attackManager;
            gameProxy.player = currentplayer;
            gameProxy.UI = UI;
            gameProxy.allies = new List<GameObject>();
            gameProxy.enemies = new List<GameObject>();
        }
    }
}