using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    protected int Health;
    protected bool IsDead;  

    public void TakeDamage()
    {
        Health -= 10;
    }

    public void CharacterDeath()
    {
        //Scene Reset
    }
    void Start()
    {
        Health = 100;
        IsDead = false;
    }

    void Update()
    {
        if (Health <= 0)
        {
            CharacterDeath();
        }
    }
}
