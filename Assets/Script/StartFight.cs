using UnityEngine;
using System.Collections;

public class StartFight : MonoBehaviour
{
    public GameObject startFightCanvas;

    Animator startAnimator;

    void Awake()
    {
        startAnimator = GameObject.Find("Canvas/Count").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!startAnimator.GetCurrentAnimatorStateInfo(0).IsName("Final"))
        {
            if (startAnimator.GetCurrentAnimatorStateInfo(0).IsName("Loading"))
            {
                startAnimator.SetBool("isStart", true);
            }
            else if (startAnimator.GetCurrentAnimatorStateInfo(0).IsName("CountController"))
            {
                startAnimator.SetBool("isStart", false);
            }
        }
        else if (startAnimator.GetCurrentAnimatorStateInfo(0).IsName("Final"))
        {
            startFightCanvas.SetActive(false);
        }
    }
}
