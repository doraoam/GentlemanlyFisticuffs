using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChoosePlayer : MonoBehaviour
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

        NextButtonCharacterSelection.player1UseAnimation = true;

        Text text = transform.Find("Player1/Player1Text").GetComponent<Text>();
        text.text = "Scottish";
    }

    void Update()
    {
        if (NextButtonCharacterSelection.playerName != null)
        {
            Text text = transform.Find("Player1/Player1Text").GetComponent<Text>();

            if (NextButtonCharacterSelection.playerName == "Scottish")
            {
                Player1MoveableSprite = Resources.LoadAll<Sprite>("Character/scottishidle");

                player1Sprite = Player1MoveableSprite[0];

                Player1Animator = GameObject.Find("Player1/playerImage").GetComponent<Animator>();
                Player1Animator.SetBool("Scottish", true);
                Player1Animator.SetBool("English", false);
                Player1Animator.enabled = true;

                NextButtonCharacterSelection.player1UseAnimation = true;
                text.text = "Scottish";
            }
            else if (NextButtonCharacterSelection.playerName == "English")
            {
                Player1MoveableSprite = Resources.LoadAll<Sprite>("Character/englishidle");

                player1Sprite = Player1MoveableSprite[0];

                Player1Animator = GameObject.Find("Player1/playerImage").GetComponent<Animator>();
                Player1Animator.SetBool("Scottish", false);
                Player1Animator.SetBool("English",true);
                Player1Animator.enabled = true;

                NextButtonCharacterSelection.player1UseAnimation = true;
                text.text = "English";
            }

            NextButtonCharacterSelection.playerName = text.text;
        }
    }
}
