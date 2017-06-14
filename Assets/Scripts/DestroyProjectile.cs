using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : WeaponBehaviour
{
    public GameObject Projectile;
    public GameObject OpponentGameObject;
    public GameObject PlayerGameObject;


    void OnTriggerEnter(Collider other)
    {
        if (OpponentGameObject.tag == "Opponent")
        {
            Destroy(Projectile);
            this._projectilecounter--;
            Debug.Log("Opponent Hit");
        }
        if (PlayerGameObject.tag == "Player")
        {
            Destroy(Projectile);
            this._projectilecounter--;
            Debug.Log("Player Hit");
        }
        else
        {
            Destroy(Projectile);
            this._projectilecounter--;
            Debug.Log("Something Was Hit");
        }
    }
}
