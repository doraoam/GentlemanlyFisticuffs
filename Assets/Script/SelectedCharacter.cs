using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;

public class SelectedCharacter : MonoBehaviour 
{
    public Sprite playerSprite;
    public Sprite[] Player1MoveableSprite;
    public Image playerImage;
    public Text playerText;
    public Animator playerAnimator;

    public Sprite enermySprite;
    public Sprite[] Player2MoveableSprite;
    public Image enermyImage;
    public Text enermyText;
    public Animator enermyAnimator;
 
    void Awake()
    {
        if (NextButtonCharacterSelection.player2Name != null)
        {
            chooseCharacter(NextButtonCharacterSelection.playerName,1);

            chooseCharacter(NextButtonCharacterSelection.player2Name,2);
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

                playerSprite = Player1MoveableSprite[0];

                playerImage = GameObject.Find("Player1/Character/Scottish").GetComponent<Image>();
                playerImage.enabled = true;

                playerAnimator = GameObject.Find("Player1/Character/Scottish").GetComponent<Animator>();
                playerAnimator.enabled = true;

                playerText = GameObject.Find("Player1/Player1Name").GetComponent<Text>();
                playerText.text = "Scottish";

                NextButtonCharacterSelection.player1UseAnimation = true;
            }
            else
            {
                Player2MoveableSprite = Resources.LoadAll<Sprite>("Character/scottishidle");

                enermySprite = Player2MoveableSprite[0];
                
                enermyImage = GameObject.Find("Player2/Character/Scottish").GetComponent<Image>();
                enermyImage.enabled = true;

                enermyAnimator = GameObject.Find("Player2/Character/Scottish").GetComponent<Animator>();
                enermyAnimator.enabled = true;

                enermyText = GameObject.Find("Player2/Player2Name").GetComponent<Text>();
                enermyText.text = "Scottish";

                NextButtonCharacterSelection.player2UseAnimation = true;
            }
        }
        else if (name == "English")
        {
            if (playerNumber == 1)
            {
                Player1MoveableSprite = Resources.LoadAll<Sprite>("Character/englishidle2");

                playerSprite = Player1MoveableSprite[0];

                playerImage = GameObject.Find("Player1/Character/English").GetComponent<Image>();
                playerImage.enabled = true;
                
                playerAnimator = GameObject.Find("Player1/Character/English").GetComponent<Animator>();
                playerAnimator.enabled = true;

                playerText = GameObject.Find("Player1/Player1Name").GetComponent<Text>();
                playerText.text = "English";

                NextButtonCharacterSelection.player1UseAnimation = true;
            }
            else
            {
                Player2MoveableSprite = Resources.LoadAll<Sprite>("Character/englishidle2");

                enermySprite = Player2MoveableSprite[0];

                enermyImage = GameObject.Find("Player2/Character/English").GetComponent<Image>();
                enermyImage.enabled = true;

                enermyAnimator = GameObject.Find("Player2/Character/English").GetComponent<Animator>();
                enermyAnimator.enabled = true;

                enermyText = GameObject.Find("Player2/Player2Name").GetComponent<Text>();
                enermyText.text = "English";

                NextButtonCharacterSelection.player2UseAnimation = true;
            }
        }
        else if (name == "Irish")
        {
            if (playerNumber == 1)
            {
                Player1MoveableSprite = Resources.LoadAll<Sprite>("Character/irkkuidle2");

                playerSprite = Player1MoveableSprite[0];

                playerImage = GameObject.Find("Player1/Character/Irish").GetComponent<Image>();
                playerImage.enabled = true;

                playerAnimator = GameObject.Find("Player1/Character/Irish").GetComponent<Animator>();
                playerAnimator.enabled = true;

                playerText = GameObject.Find("Player1/Player1Name").GetComponent<Text>();
                playerText.text = "Irish";

                NextButtonCharacterSelection.player1UseAnimation = true;
            }
            else
            {
                Player2MoveableSprite = Resources.LoadAll<Sprite>("Character/irkkuidle2");

                enermySprite = Player2MoveableSprite[0];

                enermyImage = GameObject.Find("Player2/Character/Irish").GetComponent<Image>();
                enermyImage.enabled = true;

                enermyAnimator = GameObject.Find("Player2/Character/Irish").GetComponent<Animator>();
                enermyAnimator.enabled = true;

                enermyText = GameObject.Find("Player2/Player2Name").GetComponent<Text>();
                enermyText.text = "Irish";

                NextButtonCharacterSelection.player2UseAnimation = true;
            }
        }
    }
}
