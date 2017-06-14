using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal.Execution;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponBehaviour : MonoBehaviour
{
    public GameObject ProjectileA;
    public GameObject ProjectileB;
    public GameObject ProjectileC;
    public GameObject ProjectileD;
    public GameObject Character;

    //private Transform CharacterTransform;
    private GameObject CurrentProjectile;
    private GameObject _projectileObject;
    //private Rigidbody _projectileRigidbody;
    private Transform _projectileTransform;
    private int _currentRoll;
    protected int _projectilecounter;

    public void ShootProjectile()
    {
        Roll();
        this._projectilecounter++;
        _projectileObject = Instantiate(CurrentProjectile, _projectileTransform.transform.position,
            _projectileTransform.transform.rotation);
        _projectileObject.transform.position = Character.transform.position + Character.transform.forward;
        _projectileObject.GetComponent<Rigidbody>().velocity += Character.transform.forward * 10;
    }

    public void Roll()
    {
        _currentRoll = Random.Range(1, 5);
        switch (_currentRoll)
        {
            case 1:
                {
                    CurrentProjectile = ProjectileA;
                    _projectileTransform = CurrentProjectile.GetComponent<Transform>();
                    break;
                }
            case 2:
                {
                    CurrentProjectile = ProjectileB;
                    _projectileTransform = CurrentProjectile.GetComponent<Transform>();
                    break;
                }
            case 3:
                {
                    CurrentProjectile = ProjectileC;
                    _projectileTransform = CurrentProjectile.GetComponent<Transform>();
                    break;
                }
            case 4:
                {
                    CurrentProjectile = ProjectileD;
                    _projectileTransform = CurrentProjectile.GetComponent<Transform>();
                    break;
                }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && this._projectilecounter< 3)
        {
            ShootProjectile();
        }
        else if (Input.GetKeyDown(KeyCode.Space) && this._projectilecounter >= 3)
        {
            Debug.Log("To many projectiles in scene to fire more");
        }
    }

    private void Start()
    {

    }

}
