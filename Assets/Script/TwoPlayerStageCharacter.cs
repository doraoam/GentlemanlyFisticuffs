using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TwoPlayerStageCharacter : MonoBehaviour
{
    public Sprite player1Sprite;
    public Text player1Text;
    public Animator playerAnimator;

    public Sprite player2Sprite;
    public Text player2Text;
    public Animator enermyAnimator;

    void Awake()
    {
        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer)
        {
            player1Sprite = TwoPlayerNextButtonCharacterSelection.player1Image;

            player2Sprite = TwoPlayerNextButtonCharacterSelection.player2Image;

            if (TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
            {
                playerAnimator = GameObject.Find("Player1/Image 1").GetComponent<Animator>();
                playerAnimator.enabled = true;
                playerAnimator.SetBool("Selected", true);
            }

            if (TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
            {
                enermyAnimator = GameObject.Find("Player2/Image2").GetComponent<Animator>();
                enermyAnimator.enabled = true;
                enermyAnimator.SetBool("Selected", true);
            }

            Image Image1 = transform.Find("Player1/Image 1").GetComponent<Image>();
            Image1.sprite = player1Sprite;

            Image Image2 = transform.Find("Player2/Image2").GetComponent<Image>();
            Image2.sprite = player2Sprite;
        }
        else
        {
            player1Sprite = Resources.Load<Sprite>("DC/Batman-SUMPC");
            Image Image1 = transform.Find("Player1/Image 1").GetComponent<Image>();
            Image1.sprite = player1Sprite;

            player2Sprite = player1Sprite;

            while (player2Sprite == player1Sprite)
            {
                Sprite[] images = Resources.LoadAll<Sprite>("DC/");

                // if create a new Sprite variable here will found unlimit loop.
                player2Sprite = images[Random.Range(0, images.Length)];
            }

            Image Image2 = transform.Find("Player2/Image2").GetComponent<Image>();
            Image2.sprite = player2Sprite;
        }
    }
}
