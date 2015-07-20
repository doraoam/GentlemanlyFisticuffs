using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BackgroundController : MonoBehaviour
{
    Image image;
    Animator backgroundAnimator;
    
    void Awake()
    {
        image = gameObject.AddComponent<Image>();
    }
       
    void Start()
    {    
        backgroundAnimator = GetComponent<Animator>();
  
        SpriteRenderer  spriteRenderer = GameObject.FindGameObjectWithTag("Background").GetComponent<SpriteRenderer>();

        if (spriteRenderer == null)
            Debug.LogError("Sprite renderer not found");
        else if (spriteRenderer.sprite == null)
            Debug.LogError("Sprite not found");
        else
        {
            image.sprite = spriteRenderer.sprite;
            //Debug.Log(spriteRenderer.sprite.name + " " + image.sprite.name, this);

            //TwoPlayerNextButtonCharacterSelection.backgroundImage;
        }
        /*
        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer)
        {
          //  image.sprite = TwoPlayerNextButtonCharacterSelection.backgroundImage;
            if (TwoPlayerNextButtonCharacterSelection.backgroundName == "Scotland")
            {
                //image = (Image)Resources.Load("Background/Scot/BGScot1.png");
                backgroundAnimator.SetBool("Scot", true);
            }
            else if (TwoPlayerNextButtonCharacterSelection.backgroundName == "England")
            {
                //image = (Image)Resources.Load("Background/English/BGEnglish1.png");
                backgroundAnimator.SetBool("Eng", true);
            }
            else if (TwoPlayerNextButtonCharacterSelection.backgroundName == "IrishPub")
            {
                //image = (Image)Resources.Load("Background/Iris/IrirsPub1.png");
                backgroundAnimator.SetBool("Iris", true);
            }
        }
        else 
        {
           // image.sprite = NextButtonCharacterSelection.backgroundImage;
            if (NextButtonCharacterSelection.backgroundName == "Scotland")
            {
                //image = (Image)Resources.Load("Background/Scot/BGScot1.png");
                backgroundAnimator.SetBool("Scot", true);
            }
            else if (NextButtonCharacterSelection.backgroundName == "England")
            {
                //image = (Image)Resources.Load("Background/English/BGEnglish1.png");
                backgroundAnimator.SetBool("Eng", true);
            }
            else if (NextButtonCharacterSelection.backgroundName == "IrishPub")
            {
                //image = (Image)Resources.Load("Background/Iris/IrirsPub1.png");
                backgroundAnimator.SetBool("Iris", true);
            }
        }
          */  
    }
}
