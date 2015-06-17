using UnityEngine;
using System.Collections;

public class IrishmanScript : MonoBehaviour
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

    void UpdateAnimation()
    {
        if (Input.GetKeyDown("s"))
        {
            animator.SetBool("IsPunching", true);
        }

        else
        {
            animator.SetBool("IsPunching", false);
        }
    }
}
