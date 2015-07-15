using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChooseEnermy : MonoBehaviour
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

        NextButtonCharacterSelection.player2UseAnimation = true;

        Text text = transform.Find("Player2/Player2Text").GetComponent<Text>();
        text.text = "Scottish";
    }

    void Update()
    {
        if (NextButtonCharacterSelection.player2Name != null)
        {
            Text text = transform.Find("Player2/Player2Text").GetComponent<Text>();

            if (NextButtonCharacterSelection.playerName == "Scottish")
            {
                Player2MoveableSprite = Resources.LoadAll<Sprite>("Character/scottishidle");

                player2Sprite = Player2MoveableSprite[0];

                Player2Animator = GameObject.Find("Player2/playerImage").GetComponent<Animator>();
                Player2Animator.SetBool("Scottish", true);
                Player2Animator.SetBool("English",false);
                Player2Animator.enabled = true;

                NextButtonCharacterSelection.player2UseAnimation = true;
                text.text = "Scottish";
            }
            else if (NextButtonCharacterSelection.playerName == "English")
            {
                Player2MoveableSprite = Resources.LoadAll<Sprite>("Character/englishidle");

                player2Sprite = Player2MoveableSprite[0];

                Player2Animator = GameObject.Find("Player2/playerImage").GetComponent<Animator>();
                Player2Animator.SetBool("Scottish",false);
                Player2Animator.SetBool("English", true);
                Player2Animator.enabled = true;

                NextButtonCharacterSelection.player2UseAnimation = true;
                text.text = "English";
            }

            NextButtonCharacterSelection.player2Name = text.text;
        }
    }
}
