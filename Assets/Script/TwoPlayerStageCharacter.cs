using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TwoPlayerStageCharacter : MonoBehaviour
{
    public Sprite player1Sprite;
    public Sprite[] Player1MoveableSprite;
    public Image playerImage;
    public Text player1Text;
    public Animator playerAnimator;

    public Sprite player2Sprite;
    public Sprite[] Player2MoveableSprite;
    public Image player2Image;
    public Text player2Text;
    public Animator player2Animator;

    void Awake()
    {
        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer)
        {
            chooseCharacter(TwoPlayerNextButtonCharacterSelection.player1Name, 1);

            chooseCharacter(TwoPlayerNextButtonCharacterSelection.player2Name, 2);
        }
        else
        {
            chooseCharacter("Scottish", 1);

            chooseCharacter("Scottish", 2);
        }
    }

    void chooseCharacter(string name, int playerNumber)
    {
        if (name == "Scottish")
        {
            if (playerNumber == 1)
            {
                Player1MoveableSprite = Resources.LoadAll<Sprite>("Character/scottishidle");

                player1Sprite = Player1MoveableSprite[0];

                playerImage = GameObject.Find("Player1/Character/Scottish").GetComponent<Image>();
                playerImage.enabled = true;

                playerAnimator = GameObject.Find("Player1/Character/Scottish").GetComponent<Animator>();
                playerAnimator.enabled = true;

                player1Text = GameObject.Find("Player1/Player1Name").GetComponent<Text>();
                player1Text.text = "Scottish";

                TwoPlayerNextButtonCharacterSelection.player1UseAnimation = true;
            }
            else
            {
                Player2MoveableSprite = Resources.LoadAll<Sprite>("Character/scottishidle");

                player2Sprite = Player2MoveableSprite[0];

                player2Image = GameObject.Find("Player2/Character/Scottish").GetComponent<Image>();
                player2Image.enabled = true;

                player2Animator = GameObject.Find("Player2/Character/Scottish").GetComponent<Animator>();
                player2Animator.enabled = true;

                player2Text = GameObject.Find("Player2/Player2Name").GetComponent<Text>();
                player2Text.text = "Scottish";

                TwoPlayerNextButtonCharacterSelection.player2UseAnimation = true;
            }
        }
        else if (name == "English")
        {
            if (playerNumber == 1)
            {
                Player1MoveableSprite = Resources.LoadAll<Sprite>("Character/englishidle");

                player1Sprite = Player1MoveableSprite[0];

                playerImage = GameObject.Find("Player1/Character/English").GetComponent<Image>();
                playerImage.enabled = true;

                playerAnimator = GameObject.Find("Player1/Character/English").GetComponent<Animator>();
                playerAnimator.enabled = true;

                player1Text = GameObject.Find("Player1/Player1Name").GetComponent<Text>();
                player1Text.text = "English";

                TwoPlayerNextButtonCharacterSelection.player1UseAnimation = true;
            }
            else
            {
                Player2MoveableSprite = Resources.LoadAll<Sprite>("Character/englishidle");

                player2Sprite = Player2MoveableSprite[0];

                player2Image = GameObject.Find("Player2/Character/English").GetComponent<Image>();
                player2Image.enabled = true;

                player2Animator = GameObject.Find("Player2/Character/English").GetComponent<Animator>();
                player2Animator.enabled = true;

                player2Text = GameObject.Find("Player2/Player2Name").GetComponent<Text>();
                player2Text.text = "English";

                TwoPlayerNextButtonCharacterSelection.player2UseAnimation = true;
            }
        }
        else if (name == "Irish")
        {
            if (playerNumber == 1)
            {
                Player1MoveableSprite = Resources.LoadAll<Sprite>("Character/irkkuidle2");

                player1Sprite = Player1MoveableSprite[0];

                playerImage = GameObject.Find("Player1/Character/Irish").GetComponent<Image>();
                playerImage.enabled = true;

                playerAnimator = GameObject.Find("Player1/Character/Irish").GetComponent<Animator>();
                playerAnimator.enabled = true;

                player1Text = GameObject.Find("Player1/Player1Name").GetComponent<Text>();
                player1Text.text = "Irish";

                TwoPlayerNextButtonCharacterSelection.player1UseAnimation = true;
            }
            else
            {
                Player2MoveableSprite = Resources.LoadAll<Sprite>("Character/irkkuidle2");

                player2Sprite = Player2MoveableSprite[0];

                player2Image = GameObject.Find("Player2/Character/Irish").GetComponent<Image>();
                player2Image.enabled = true;

                player2Animator = GameObject.Find("Player2/Character/Irish").GetComponent<Animator>();
                player2Animator.enabled = true;

                player2Text = GameObject.Find("Player2/Player2Name").GetComponent<Text>();
                player2Text.text = "Irish";

                TwoPlayerNextButtonCharacterSelection.player2UseAnimation = true;
            }
        }
    }
}
