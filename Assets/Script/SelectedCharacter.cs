using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;

public class SelectedCharacter : MonoBehaviour 
{
    public Sprite playerSprite;
    public Text playerText;
    public Animator playerAnimator;

    public Sprite enermySprite;
    public Text enermyText;
    public Animator enermyAnimator;
 
    void Awake()
    {
        if (NextButtonCharacterSelection.player2Image)
        {
            playerSprite = NextButtonCharacterSelection.playerImage;
            Image Image1 = transform.Find("Player1/Image 1").GetComponent<Image>();
            Image1.sprite = playerSprite;

            if (NextButtonCharacterSelection.player1UseAnimation)
            {
                playerAnimator = GameObject.Find("Player1/Image 1").GetComponent<Animator>();
                playerAnimator.enabled = true;
                //playerAnimator.SetBool("Selected", true);
            }

            enermySprite = NextButtonCharacterSelection.player2Image;
            Image Image2 = transform.Find("Player2/Image2").GetComponent<Image>();
            Image2.sprite = enermySprite;

            if (NextButtonCharacterSelection.player2UseAnimation)
            {
                enermyAnimator = GameObject.Find("Player2/Image2").GetComponent<Animator>();
                enermyAnimator.enabled = true;
                //enermyAnimator.SetBool("Selected", true);
            }
        }
        else
        {
            playerSprite = Resources.Load<Sprite>("DC/Batman-SUMPC");
            Image Image1 = transform.Find("Player1/Image 1").GetComponent<Image>();
            Image1.sprite = playerSprite;

            enermySprite = playerSprite;

            while (enermySprite == playerSprite)
            {
                Sprite[] images = Resources.LoadAll<Sprite>("DC/");

                // if create a new Sprite variable here will found unlimit loop.
                enermySprite = images[Random.Range(0, images.Length)];
            }

            Image Image2 = transform.Find("Player2/Image2").GetComponent<Image>();
            Image2.sprite = enermySprite;
        }
    }


}
