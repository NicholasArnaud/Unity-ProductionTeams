using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//For Buttons on Menu
public class MenuController : MonoBehaviour
{
    [HideInInspector]
    public Button theButton;
   
    private string CurrentCase;



    void Start()
    {
        theButton = GetComponent<Button>();
    }
    

    //Actions for buttons being clicked
    public bool GetButtonInput()
    {
        
        return false;
    }

    //The actions of the buttons
    public string DoButtonAction()
    {
        switch (CurrentCase)
        {
            case "Start":

            case "Credits":

            case "Quit":

            default:
                return null;
        }

    }

}
