using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BackgroundController : MonoBehaviour
{
    Image image;
    Animator backgroundAnimator;

    void Awake()
    {
        image = GetComponent<Image>();
        backgroundAnimator = GetComponent<Animator>();
        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer)
        {
            if (TwoPlayerNextButtonCharacterSelection.backgroundName == "Scotland")
            {
                image = (Image)Resources.Load("Background/Scot/BGScot1");
                backgroundAnimator.SetBool("Scot", true);
            }
            else if (TwoPlayerNextButtonCharacterSelection.backgroundName == "England")
            {
                image = (Image)Resources.Load("Background/English/BGEnglish1.png");
                backgroundAnimator.SetBool("Eng", true);
            }
            else if (TwoPlayerNextButtonCharacterSelection.backgroundName == "IrishPub")
            {
                image = (Image)Resources.Load("Background/Iris/IrirsPub1");
                backgroundAnimator.SetBool("Iris", true);
            }
        }
        else 
        {
            if (NextButtonCharacterSelection.backgroundName == "Scotland")
            {
                image = (Image)Resources.Load("Background/Scot/BGScot1");
                backgroundAnimator.SetBool("Scot", true);
            }
            else if (NextButtonCharacterSelection.backgroundName == "England")
            {
                image = (Image)Resources.Load("Background/English/BGEnglish1.png");
                backgroundAnimator.SetBool("Eng", true);
            }
            else if (NextButtonCharacterSelection.backgroundName == "IrishPub")
            {
                image = (Image)Resources.Load("Background/Iris/IrirsPub1");
                backgroundAnimator.SetBool("Iris", true);
            }
        }
            
    }
}
