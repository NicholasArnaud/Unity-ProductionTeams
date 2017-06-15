using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpponentWeaponBehaviour : MonoBehaviour
{
    public static OpponentWeaponBehaviour instance;
    public List<GameObject> ProjectileList;
    public Transform target;


    public int projectileCounter;
    private bool InSight;
    
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
        _projectileObject.transform.position = transform.position + transform.forward+ transform.forward;
        _projectileObject.GetComponent<Rigidbody>().velocity += transform.forward * 10;
    }

    public void Roll()
    {
        _currentRoll = Random.Range(0, ProjectileList.Count);
        CurrentProjectile = ProjectileList[_currentRoll];
        _projectileTransform = CurrentProjectile.GetComponent<Transform>();
    }

    public float fireDelay;
    [SerializeField]
    private float timer;

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 50.0f))
        {
            
            if (hit.transform == target)
            {
                timer += Time.deltaTime;
                if (timer >= fireDelay)
                {
                    ShootProjectile();
                    timer = 0;
                }
                Debug.Log("Hit Player");
            }
        }        
    }

    private void Start()
    {
        instance = this;
        projectileCounter = 0;
    }

    IEnumerator Timer()
    {
        for (int i = 0; i < 7; i++)
        {
            ShootProjectile();
            yield return new WaitForSecondsRealtime(0.3f);
        }

    }

}
