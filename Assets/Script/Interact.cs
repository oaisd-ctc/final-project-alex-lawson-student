using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public bool talk = false;
    public Animator animator;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("talkble"))
        {
            animator.SetBool("Yappa", true);
            talk = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("talkble"))
        {
            animator.SetBool("Yappa", false);
            talk = false;
        }
    }
}
