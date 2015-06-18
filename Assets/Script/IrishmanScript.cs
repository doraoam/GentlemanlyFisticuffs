using UnityEngine;
using System.Collections;

public class IrishmanScript : MonoBehaviour
{
    Animator animator;
    bool IsPunching;

    //public AudioClip[] audioClip;

    public AudioSource au_Punch;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();

        au_Punch = (AudioSource)gameObject.AddComponent<AudioSource>();
        AudioClip audioClip;
        audioClip = (AudioClip)Resources.Load("SFX/Punch");
        au_Punch.clip = audioClip;
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

            au_Punch.PlayDelayed(delay: 0.2f);
            //PlaySound(0);
        }

        else
        {
            animator.SetBool("IsPunching", false);
        }
    }

    /*void PlaySound(int clip)
    {
        
        audio.clip = audioClip[clip];
        audio.Play();
    }*/
}
