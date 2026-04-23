using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Interact it;
    public SpriteRenderer SR;
    public Rigidbody2D RD;
    public Animator animator;
    public float moveSpeed = 5f;
    
    


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

        if(horizontal > 0)
        {
            animator.SetBool("Walking", true);
            animator.SetBool("Talking", false);
            SR.flipX = false;
        }
        else if (horizontal < 0)
        {
            animator.SetBool("Walking", true);
            animator.SetBool("Talking", false);
            SR.flipX = true;
        }
        else if (vertical != 0)
        {
            animator.SetBool("Walking", true);
        }
        else if(it.talk == true)
        {
            animator.SetBool("Walking", false);
            animator.SetBool("Talking", true);
        }
        else
        {
            animator.SetBool("Walking", false);
            animator.SetBool("Talking", false);
        }
            Vector2 movement = new Vector2(horizontal, vertical).normalized;


        RD.velocity = movement * moveSpeed;

    }
}
