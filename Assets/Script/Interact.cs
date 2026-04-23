using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    [SerializeField] SkillCheck sc;
    public bool talk = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("talkble"))
        {
            Animator anim = other.gameObject.GetComponentInParent<Animator>();
            anim.SetBool("Yappa", true);
            talk = true;
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (sc.talkable == false)
        {
            Animator anim = other.gameObject.GetComponentInParent<Animator>();
            anim.SetBool("Yappa", false);
            other.gameObject.tag = "NPC";
            talk = false;

            sc.Check = false;
            sc.talkable = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("talkble"))
        {
            Animator anim = other.gameObject.GetComponentInParent<Animator>();
            anim.SetBool("Yappa", false);
            talk = false;
        }
    }
}
