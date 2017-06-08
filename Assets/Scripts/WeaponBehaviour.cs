using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehaviour : MonoBehaviour
{
    public GameObject ProjectileA;
    public GameObject ProjectileB;
    public GameObject ProjectileC;
    public GameObject ProjectileD;
    public GameObject Character;

    public GameObject CurrentProjectile;

    private Rigidbody _projectileRigidbody;
    private Transform _projectileTransform;

    private int _currentRoll;

    public void ShootProjectile()
    {
        Roll();
        var firedProjectile = Instantiate(_projectileRigidbody, _projectileTransform.position,
            _projectileTransform.rotation);
        firedProjectile.transform.position = Character.transform.position + Character.transform.forward;
        firedProjectile.velocity += Character.transform.forward;
    }

    public void Roll()
    {
        _currentRoll = Random.Range(1, 4);
        switch (_currentRoll)
        {
            case 1:
                {
                    CurrentProjectile = ProjectileA;
                    _projectileRigidbody = CurrentProjectile.GetComponent<Rigidbody>();
                    _projectileTransform = CurrentProjectile.GetComponent<Transform>();
                    break;
                }
            case 2:
                {
                    CurrentProjectile = ProjectileB;
                    _projectileRigidbody = CurrentProjectile.GetComponent<Rigidbody>();
                    _projectileTransform = CurrentProjectile.GetComponent<Transform>();
                    break;
                }
            case 3:
                {
                    CurrentProjectile = ProjectileC;
                    _projectileRigidbody = CurrentProjectile.GetComponent<Rigidbody>();
                    _projectileTransform = CurrentProjectile.GetComponent<Transform>();
                    break;
                }
            case 4:
                {
                    CurrentProjectile = ProjectileD;
                    _projectileRigidbody = CurrentProjectile.GetComponent<Rigidbody>();
                    _projectileTransform = CurrentProjectile.GetComponent<Transform>();
                    break;
                }
        }
    }


    void update()
    {
        ShootProjectile();
    }

    void Start()
    {
        ShootProjectile();

    }

}
