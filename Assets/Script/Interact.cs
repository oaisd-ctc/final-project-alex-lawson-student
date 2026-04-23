using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public bool talk = false;
    public Animator animator;
    [SerializeField] SkillCheck sc;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("talkble"))
        {
            animator.SetBool("Yappa", true);
            talk = true;
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (sc.talkable == false)
        {
            animator.SetBool("Yappa", false);
            other.gameObject.tag = "NPC";
            talk = false;
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
