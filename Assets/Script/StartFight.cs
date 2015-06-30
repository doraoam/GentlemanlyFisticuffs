using UnityEngine;
using System.Collections;

public class StartFight : MonoBehaviour
{
    public GameObject startFightCanvas;

    public Animator startAnimator;

    void start()
    {
        startAnimator.SetBool("isStart", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!startAnimator.GetCurrentAnimatorStateInfo(0).IsName("CountController"))
        {
            startAnimator.SetBool("isStart",false);
            startFightCanvas.SetActive(false);
        }
        else
        {
            startFightCanvas.SetActive(true);
        }
    }
}
