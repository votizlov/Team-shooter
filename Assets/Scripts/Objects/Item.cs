using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public abstract void ApplyBonus(PlayerController playerController);
    public abstract void RemoveBonus(PlayerController playerController);
}
