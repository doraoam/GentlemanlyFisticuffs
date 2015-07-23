using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BackgroundController : MonoBehaviour
{
    Image image;
    Animator backgroundAnimator;

    string backgroundName;

    void Awake()
    {
        //image = gameObject.AddComponent<Image>();
        image = GetComponent<Image>();
        //image.sprite = Resources.Load<Sprite>("Background/Scot/BGScot1");
        //Debug.Log(image.sprite, this);

        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer)
        {
            backgroundName = TwoPlayerNextButtonCharacterSelection.backgroundName;
        }
        else
        {
            backgroundName = NextButtonCharacterSelection.backgroundName;
        }
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
    }

    void FixedUpdate()
    {
        //  image.sprite = TwoPlayerNextButtonCharacterSelection.backgroundImage;
        if (backgroundName == "Scotland")
        {
            //image = (Image)Resources.Load("Background/Scot/BGScot1.png");
            backgroundAnimator.SetBool("Scot", true);
        }
        else if (backgroundName == "England")
        {
            //image = (Image)Resources.Load("Background/English/BGEnglish1.png");
            backgroundAnimator.SetBool("Eng", true);
        }
        else 
        {
            //image = (Image)Resources.Load("Background/Iris/IrirsPub1.png");
            backgroundAnimator.SetBool("Iris", true);
        }
    }
}
