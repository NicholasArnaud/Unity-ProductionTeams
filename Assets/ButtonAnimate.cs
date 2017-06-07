using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimate : MonoBehaviour
{

    private Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void MouseOver()
    {
        animator.SetTrigger("Hilighted");
    }

    public void Selected()
    {
        animator.SetTrigger("Pressed");
    }
}
