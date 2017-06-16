using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public GameObject LoseMenu;
    public static PlayerStats InstancePlayerStats;
    private bool IsDead;
    private float Health;
    [SerializeField]
    private Text TextHealth;
    [SerializeField]
    private float CurrentHealth;
    private float ProjectileDmg;
    int checkDeath;
    private Animator animator;
    private float deadTimer;
    private int deadCounter;

    public void TakeDamage()
    {
        CurrentHealth -= ProjectileDmg;
    }

    public bool CharacterDeath()
    {
        if (checkDeath == 1)
        {
            animator.SetTrigger("Dead");
        }
        this.IsDead = true;
        // Animation

        /*Once Animation is done then...*/
        //this.gameObject.SetActive(false);
        if (animationDone())
        {
            Time.timeScale = 0.0f;
            LoseMenu.SetActive(true);
        }
        return false;
    }

    private bool animationDone()
    {
        deadTimer += Time.deltaTime;
        if (deadTimer >= 2.0f)
        {
            return true;
        }
        return false;
    }


    void Death()
    {
        animator.SetTrigger("Dead");
    }

    void Start()
    {
        checkDeath = 0;
        deadCounter = 0;
        deadTimer = 0;
        Health = 100;
        CurrentHealth = Health;
        IsDead = false;
        ProjectileDmg = 10;
        InstancePlayerStats = this;
        TextHealth.text = "Player Health : " + CurrentHealth;
        LoseMenu.SetActive(false);
        animator = GetComponent<Animator>();

    }

    public void ResetTime()
    {
        Time.timeScale = 1.0f;
    }

    void Update()
    {

        if (CurrentHealth <= 0)
        {
            //CharacterDeath();
            //checkDeath = 1;
            IsDead = true;
            if (deadCounter < 1)
            {
                Death();
            }
            deadCounter += 1;
        }

        if (IsDead == true)
        {
            if (animationDone())
            { 
                LoseMenu.SetActive(true);
            }
            
        }

        if (LoseMenu.active == true)
        {
            Time.timeScale = 0.0f;
        }
        else
            Time.timeScale = 1.0f;

        TextHealth.text = "Player Health : " + CurrentHealth;
    }
}
