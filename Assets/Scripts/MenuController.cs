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

    public Canvas buttonCanvas;
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
        GameObject startButton;
        startButton = Instantiate(buttonObject);
        startButton.tag = "Start";
        startButton.transform.SetParent(buttonCanvas.transform);
        startButton.transform.position = new Vector3(300, 300, 0);
        startButton.GetComponentInChildren<Text>().text = "Start";
        startButton.name = "Start";

        GameObject creditsButton;
        creditsButton = Instantiate(buttonObject);
        creditsButton.tag = "Credits";
        creditsButton.transform.SetParent(buttonCanvas.transform);
        creditsButton.transform.position = new Vector3(500, 300, 0);
        creditsButton.GetComponentInChildren<Text>().text = "Credits";
        creditsButton.name = "Credits";

        GameObject quitButton;
        quitButton = Instantiate(buttonObject);
        quitButton.tag = "Quit";
        quitButton.transform.SetParent(buttonCanvas.transform);
        quitButton.transform.position = new Vector3(700, 300, 0);
        quitButton.GetComponentInChildren<Text>().text = "Quit";
        quitButton.name = "Quit";

    }

    void Start()
    {
        CreateButtons();
    }

    void Update()
    {
        GetButtonInput();
    }



}
