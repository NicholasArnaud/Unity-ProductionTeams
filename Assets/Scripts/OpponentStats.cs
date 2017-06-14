using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpponentStats : MonoBehaviour
{
    public static OpponentStats InstanceOpponentStats;
    public bool IsDead;
    public float Health;
    public float CurrentHealth;
    public float ProjectileDmg;

    public void TakeDamage()
    {
        CurrentHealth -= ProjectileDmg;
    }

    public void CharacterDeath()
    {
        this.IsDead = true;
        // Animation
        /*Once Animation is done then...*/ this.gameObject.SetActive(false);
    }

    public void UpdateUI()
    {
        if (CurrentHealth <= 0)
        {
            CharacterDeath();
        }
    }

    void Start()
    {
        Health = 100;
        CurrentHealth = Health;
        IsDead = false;
        ProjectileDmg = 10;
        InstanceOpponentStats = this;
    }

    void Update()
    {
        UpdateUI();
    }
}
