using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponBehaviour : MonoBehaviour
{
    public static WeaponBehaviour instance;
    public List<GameObject> ProjectileList;



    public int projectileCounter;

    private GameObject CurrentProjectile;
    private GameObject _projectileObject;
    private Transform _projectileTransform;
    private int _currentRoll;

    public void ShootProjectile()
    {
        Roll();
        projectileCounter++;
        _projectileObject = Instantiate(CurrentProjectile, _projectileTransform.transform.position,
            _projectileTransform.transform.rotation);
        _projectileObject.transform.position = transform.position + transform.forward *2;
        _projectileObject.GetComponent<Rigidbody>().velocity += transform.forward * 10;
    }

    public void Roll()
    {
        _currentRoll = Random.Range(0, ProjectileList.Count);
        CurrentProjectile = ProjectileList[_currentRoll];
        _projectileTransform = CurrentProjectile.GetComponent<Transform>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootProjectile();
            projectileCounter++;
        }
    }

    private void Start()
    {
        instance = this;
        projectileCounter = 0;
    }

 

}
