using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameProxy gameProxy;
    // Start is called before the first frame update
    void Start()
    {
        AttackManager attackManager = new AttackManager();
        gameProxy.attackManager = attackManager;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
