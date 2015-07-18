using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TwoPlayerSelect : MonoBehaviour
{
    public Sprite player2Sprite;
    public Text player2Text;

    public Sprite[] Player2MoveableSprite;

    public Animator Player2Animator;

    void Start()
    {
        Player2MoveableSprite = Resources.LoadAll<Sprite>("Character/scottishidle");

        player2Sprite = Player2MoveableSprite[0];

        Player2Animator = GameObject.Find("Player2/playerImage").GetComponent<Animator>();
        Player2Animator.SetBool("Scottish", true);
        Player2Animator.enabled = true;

        TwoPlayerNextButtonCharacterSelection.player2UseAnimation = true;

        Text text = transform.Find("Player2/Player2Text").GetComponent<Text>();
        text.text = "Scottish";
    }

    void Update(){
        if (TwoPlayerNextButtonCharacterSelection.player2Name != null)
        {
            Text text = transform.Find("Player2/Player2Text").GetComponent<Text>();

            if (TwoPlayerNextButtonCharacterSelection.player1Name == "Scottish")
            {
                Player2MoveableSprite = Resources.LoadAll<Sprite>("Character/scottishidle");

                player2Sprite = Player2MoveableSprite[0];

                Player2Animator = GameObject.Find("Player2/playerImage").GetComponent<Animator>();
                Player2Animator.SetBool("Scottish", true);
                Player2Animator.SetBool("English", false);
                Player2Animator.enabled = true;

                TwoPlayerNextButtonCharacterSelection.player2UseAnimation = true;
                text.text = "Scottish";
            }
            else if (TwoPlayerNextButtonCharacterSelection.player1Name == "English")
            {
                Player2MoveableSprite = Resources.LoadAll<Sprite>("Character/englishidle");

                player2Sprite = Player2MoveableSprite[0];

                Player2Animator = GameObject.Find("Player2/playerImage").GetComponent<Animator>();
                Player2Animator.SetBool("Scottish", false);
                Player2Animator.SetBool("English", true);
                Player2Animator.enabled = true;

                TwoPlayerNextButtonCharacterSelection.player2UseAnimation = true;
                text.text = "English";
            }

            text.text = TwoPlayerNextButtonCharacterSelection.player2Name;
        }
    }
}
