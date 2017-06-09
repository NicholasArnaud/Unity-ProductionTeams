using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour
{
    public GameObject Projectile;
    public GameObject OpponentGameObject;
    public GameObject PlayerGameObject;


    void OnTriggerEnter(Collider other)
    {
        if (OpponentGameObject.tag == "Opponent")
        {
            Destroy(Projectile);
            Debug.Log("Opponent Hit");
        }
        if(PlayerGameObject.tag == "Player")
        {
            Destroy(Projectile);
            Debug.Log("Player Hit");
        }
        else
            Destroy(Projectile);
        Debug.Log("Something Was Hit");
    }
}
