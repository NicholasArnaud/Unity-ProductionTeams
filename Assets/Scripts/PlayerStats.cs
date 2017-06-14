using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{

    protected bool IsDead;

    private float Health;
    private float CurrentHealth;
    private float ProjectileDmg;

    public void TakeDamage()
    {
        CurrentHealth -= ProjectileDmg;
    }

    public void CharacterDeath()
    {
        IsDead = true;
        // Animation
        /*Once Animation is done then...*/ gameObject.SetActive(false);
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
    }

    void Update()
    {
        UpdateUI();
    }
}
