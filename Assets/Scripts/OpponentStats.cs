using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpponentStats : MonoBehaviour
{
    public static OpponentStats InstanceOpponentStats;
    private bool IsDead;
    private float Health;
    [SerializeField]
    private Text TextHealth;
    [SerializeField]
    private float CurrentHealth;
    private float ProjectileDmg;

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
        TextHealth.text = "Enemy Health : " + CurrentHealth;
    }

    void Update()
    {
        UpdateUI();
        TextHealth.text = "Enemy Health : " + CurrentHealth;
    }
}
