using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnimate : MonoBehaviour
{

    private Animator animator;
    private Button DaButton;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        DaButton = GetComponent<Button>();
    }

    public void Hover()
    {
        animator.SetTrigger("Hilighted");
    }

    public void Selected()
    {
        animator.SetTrigger("Pressed");
    }
}
