using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

//For Buttons on Menu
public class MenuController : MonoBehaviour
{
    [HideInInspector]

    public Button theButton;
    public Text testText;

    private string CurrentCase;
    
    //Actions for buttons being clicked
    public void GetButtonInput()
    {
        if (theButton.tag == "Start")
        {
            CurrentCase = "Start";
            DoButtonAction();
        }
        if (theButton.tag == "Credits")
        {
            CurrentCase = "Credits";
            DoButtonAction();
        }
        if (theButton.tag == "Quit")
        {
            CurrentCase = "Quit";
            DoButtonAction();
        }
    }

    //The actions of the buttons
    public string DoButtonAction()
    {
        switch (CurrentCase)
        {
            case "Start":
                {
                    Debug.Log("Start Button was Pressed");
                    testText.text = "Start Button was Pressed";
                    return CurrentCase;
                }
            case "Credits":
                {
                    Debug.Log("Credits Button was Pressed");
                    testText.text = "Credits Button was Pressed";
                    return CurrentCase;
                }
            case "Quit":
                {
                    Debug.Log("Quit Button was Pressed");
                    testText.text = "Quit Button was Pressed";
                    return CurrentCase;
                }
            default:
                return null;
        }

    }


    void Update()
    {
        GetButtonInput();
    }



}
