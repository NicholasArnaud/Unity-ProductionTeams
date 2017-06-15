using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            WeaponBehaviour.instance.projectileCounter--;
            PlayerStats.InstancePlayerStats.TakeDamage();
            Debug.Log("Player was hit.");
        }
        if (other.tag == "Opponent")
        {
            Destroy(gameObject);
            OpponentWeaponBehaviour.instance.projectileCounter--;
            OpponentStats.InstanceOpponentStats.TakeDamage();
            Debug.Log("Opponet was hit.");
        }
        else
        {
            Destroy(gameObject);
            WeaponBehaviour.instance.projectileCounter--;
            OpponentWeaponBehaviour.instance.projectileCounter--;
            Debug.Log("Something was hit.");
        }
    }
}

