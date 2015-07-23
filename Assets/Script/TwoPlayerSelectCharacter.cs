using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TwoPlayerSelectCharacter : MonoBehaviour
{
    public Sprite player1Sprite;
    public Text player1Text;

    public Sprite[] Player1MoveableSprite;

    public Animator Player1Animator;

    void Start()
    {
        Player1MoveableSprite = Resources.LoadAll<Sprite>("Character/scottishidle");

        player1Sprite = Player1MoveableSprite[0];

        Player1Animator = GameObject.Find("Player1/playerImage").GetComponent<Animator>();
        Player1Animator.SetBool("Scottish", true);
        Player1Animator.enabled = true;

        TwoPlayerNextButtonCharacterSelection.player1UseAnimation = true;

        Text text = transform.Find("Player1/Player1Text").GetComponent<Text>();
        text.text = "Scottish";
    }

    void Update(){
        if (TwoPlayerNextButtonCharacterSelection.player1Name != null)
        {
            Text text = transform.Find("Player1/Player1Text").GetComponent<Text>();

            if (TwoPlayerNextButtonCharacterSelection.player1Name == "Scottish")
            {
                Player1MoveableSprite = Resources.LoadAll<Sprite>("Character/scottishidle");

                player1Sprite = Player1MoveableSprite[0];

                Player1Animator = GameObject.Find("Player1/playerImage").GetComponent<Animator>();
                Player1Animator.SetBool("Scottish", true);
                Player1Animator.SetBool("English", false);
                Player1Animator.SetBool("Irish", false);
                Player1Animator.enabled = true;

                TwoPlayerNextButtonCharacterSelection.player1UseAnimation = true;
                text.text = "Scottish";
            }
            else if (TwoPlayerNextButtonCharacterSelection.player1Name == "English")
            {
                Player1MoveableSprite = Resources.LoadAll<Sprite>("Character/englishidle");

                player1Sprite = Player1MoveableSprite[0];

                Player1Animator = GameObject.Find("Player1/playerImage").GetComponent<Animator>();
                Player1Animator.SetBool("Scottish", false);
                Player1Animator.SetBool("English", true);
                Player1Animator.SetBool("Irish", false);
                Player1Animator.enabled = true;

                TwoPlayerNextButtonCharacterSelection.player1UseAnimation = true;
                text.text = "English";
            }
            else if (TwoPlayerNextButtonCharacterSelection.player1Name == "Irish")
            {
                Player1MoveableSprite = Resources.LoadAll<Sprite>("Character/irkkuidle2");

                player1Sprite = Player1MoveableSprite[0];

                Player1Animator = GameObject.Find("Player1/playerImage").GetComponent<Animator>();
                Player1Animator.SetBool("Scottish", false);
                Player1Animator.SetBool("English", false);
                Player1Animator.SetBool("Irish", true);
                Player1Animator.enabled = true;

                TwoPlayerNextButtonCharacterSelection.player1UseAnimation = true;
                text.text = "Irish";
            }

            TwoPlayerNextButtonCharacterSelection.player1Name = text.text;
        }
    }
}
