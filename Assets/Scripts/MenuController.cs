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

    public GameObject buttonCanvas;
    public GameObject buttonObject;
    public Text buttonText;
    public Text testText;

    private string CurrentCase;
    private int currentButtonPos;

    //Actions for buttons being clicked
    public void GetButtonInput()
    {
        if (theButton.CompareTag("Start"))
        {
            CurrentCase = "Start";
            DoButtonAction();
        }
        if (theButton.CompareTag("Credits"))
        {
            CurrentCase = "Credits";
            DoButtonAction();
        }
        if (theButton.CompareTag("Quit"))
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

    //Create buttons for scene
    public void CreateButtons()
    {
        if (currentButtonPos == 0)
        {
            Instantiate(buttonObject).tag = "Start";
            if (buttonObject.CompareTag("Start"))
            {
                buttonObject.transform.position = new Vector3(0, 0, 0);
                buttonText.text = "Start";
                currentButtonPos = 1;
                CreateButtons();
            }
        }
        if (currentButtonPos == 1)
        {
            Instantiate(buttonObject).tag = "Credits";
            if (buttonObject.CompareTag("Credits"))
            {
                buttonObject.transform.position = new Vector3(100, 0, 0);
                buttonText.text = "Credits";
                currentButtonPos = 2;
                CreateButtons();
            }
        }
        if (currentButtonPos == 2)
        {
            Instantiate(buttonObject).tag = "Quit";
            if (buttonObject.CompareTag("Quit"))
            {
                buttonObject.transform.position = new Vector3(-100, 0, 0);
                buttonText.text = "Quit";
                currentButtonPos = 3;
            }
        }
    }

    void Start()
    {
        currentButtonPos = 0;
        CreateButtons();
    }

    void Update()
    {
        GetButtonInput();
    }



}
