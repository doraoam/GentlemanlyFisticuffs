using UnityEngine;
using System.Collections;

public class Scott : MonoBehaviour
{
    Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAnimation();
    }

    bool isIdle = false;
    bool isAttacking = false;
    bool isDefending = false;

    void UpdateAnimation()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (animator.GetBool("isAttacking"))
            {
                animator.SetBool("isAttacking", true);
                animator.SetBool("isDefending", false);
            }


        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (animator.GetBool("isDefending"))
            {
                animator.SetBool("isAttacking", false);
                animator.SetBool("isDefending", true);
            }
        }

        else
        {
            animator.SetBool("isIdle", true);
        }


    }
}
