using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameProxy gameProxy;

    [SerializeField] private AttackManager attackManager;

    [SerializeField] private PlayerController currentplayer;

    [SerializeField] private UIController UI;
    // Start is called before the first frame update
    void Awake()
    {
        gameProxy.attackManager = attackManager;
        gameProxy.player = currentplayer;
        gameProxy.UI = UI;
        gameProxy.allies.Add(currentplayer.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
