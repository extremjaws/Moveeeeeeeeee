using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hover : MonoBehaviour
{
    public GameObject Button;
    public void Animateactive()
    {
        Animator animator = Button.GetComponent<Animator>();
        bool isOpen = animator.GetBool("open");
        animator.SetBool("open", !isOpen);
    }
}
