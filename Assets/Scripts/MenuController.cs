using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

//For Buttons on Menu
public class MenuController : MonoBehaviour
{
    [HideInInspector]
    public Button TheButton;

    public Canvas ButtonCanvas;
    public GameObject ButtonObject;
    public Text ButtonText;

    //The actions of the buttons
    public void DoButtonAction()
    {
        

    }

    //Create buttons for scene
    public void CreateButtons()
    {
        GameObject startButton = Instantiate(ButtonObject);
        startButton.tag = "Start";
        startButton.transform.SetParent(ButtonCanvas.transform);
        startButton.transform.position = new Vector3(300, 300, 0);
        startButton.GetComponentInChildren<Text>().text = "Start";
        startButton.name = "Start";

        GameObject creditsButton = Instantiate(ButtonObject);
        creditsButton.tag = "Credits";
        creditsButton.transform.SetParent(ButtonCanvas.transform);
        creditsButton.transform.position = new Vector3(500, 300, 0);
        creditsButton.GetComponentInChildren<Text>().text = "Credits";
        creditsButton.name = "Credits";

        GameObject quitButton = Instantiate(ButtonObject);
        quitButton.tag = "Quit";
        quitButton.transform.SetParent(ButtonCanvas.transform);
        quitButton.transform.position = new Vector3(700, 300, 0);
        quitButton.GetComponentInChildren<Text>().text = "Quit";
        quitButton.name = "Quit";
    }



    public void Start()
    {
        CreateButtons();
    }

    public void Update()
    {
        
    }

}
