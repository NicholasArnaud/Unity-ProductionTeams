using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    protected int Health;
    protected bool IsColliding;

    void Start()
    {
        Health = 100;
        IsColliding = false;
    }

    void Update()
    {

    }
}
