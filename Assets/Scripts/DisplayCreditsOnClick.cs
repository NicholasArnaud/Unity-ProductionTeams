using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DisplayCreditsOnClick : MonoBehaviour
{
    public GameObject MenuCamera;
    public GameObject CreditsCamera;

    public void SwitchToCredits()
    {
        MenuCamera.SetActive(false);
        CreditsCamera.SetActive(true);
    }

    public void SwitchToMainMenu()
    {
        MenuCamera.SetActive(true);
        CreditsCamera.SetActive(false);
    }

    void Start()
    {
        CreditsCamera.SetActive(false);
    }

    
}
