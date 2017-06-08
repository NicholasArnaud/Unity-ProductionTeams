using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DisplayCreditsOnClick : MonoBehaviour
{
    public GameObject MenuCamera;
    public GameObject CreditsCamera;
    public GameObject ControlsCamera;

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

    public void SwitchToMainMenuAlt()
    {
        MenuCamera.SetActive(true);
        ControlsCamera.SetActive(false);
    }

    public void SwitchToControls()
    {
        MenuCamera.SetActive(false);
        ControlsCamera.SetActive(true);
    }

    void Start()
    {
        CreditsCamera.SetActive(false);
    }

    
}
