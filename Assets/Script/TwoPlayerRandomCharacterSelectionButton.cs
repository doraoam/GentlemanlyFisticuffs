using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TwoPlayerRandomCharacterSelectionButton : MonoBehaviour
{
    string player1Name;
    string player2Name;

    Sprite sprite;
    Sprite sprite2;

    Sprite[] Player1MoveableSprite;
    Sprite[] Player2MoveableSprite;

    Animator Player1Animator;
    Animator Player2Animator;

    public void onClickRandom()
    {
        string[] name = new string[] { "Scottish", "English" };

        if (TwoPlayerNextButtonCharacterSelection.player1Name != null)
        {

        }
        else
        {
            player1Name = name[Random.Range(0, name.Length - 1)];

            chooseCharacter(player1Name, 1);

            Text text = transform.Find("Player1/Player1Text").GetComponent<Text>();
            text.text = player1Name;
            TwoPlayerNextButtonCharacterSelection.player1Name = player1Name;

            TwoPlayerNextButtonCharacterSelection.enablePlayer1 = false;
        }

        player2Name = name[Random.Range(0, name.Length - 1)];

        chooseCharacter(player2Name, 2);

        Text text2 = transform.Find("Player2/Player2Text").GetComponent<Text>();
        text2.text = player2Name;
        TwoPlayerNextButtonCharacterSelection.player2Name = player2Name;

        TwoPlayerNextButtonCharacterSelection.enablePlayer2 = false;

        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer != true)
        {
            TwoPlayerNextButtonCharacterSelection.isTwoPlayer = true;
        }

        Application.LoadLevel("TwoPlayerStage");
    }

    void chooseCharacter(string name, int playerNumber)
    {
        if (name == "Scottish")
        {
            if (playerNumber == 1)
            {
                Player1MoveableSprite = Resources.LoadAll<Sprite>("Character/scottishidle");

                sprite = Player1MoveableSprite[0];

                Player1Animator = GameObject.Find("Player1/playerImage").GetComponent<Animator>();
                Player1Animator.SetBool("Scottish", true);
                Player1Animator.SetBool("English", false);
                Player1Animator.enabled = true;

                TwoPlayerNextButtonCharacterSelection.player1UseAnimation = true;
            }
            else
            {
                Player2MoveableSprite = Resources.LoadAll<Sprite>("Character/scottishidle");

                sprite = Player2MoveableSprite[0];

                Player2Animator = GameObject.Find("Player2/playerImage").GetComponent<Animator>();
                Player2Animator.SetBool("Scottish", true);
                Player2Animator.SetBool("English", false);
                Player2Animator.enabled = true;

                TwoPlayerNextButtonCharacterSelection.player2UseAnimation = true;
            }
        }
        else if (name == "English")
        {
            if (playerNumber == 1)
            {
                Player1MoveableSprite = Resources.LoadAll<Sprite>("Character/englishidle");

                sprite = Player1MoveableSprite[0];

                Player1Animator = GameObject.Find("Player1/playerImage").GetComponent<Animator>();
                Player1Animator.SetBool("Scottish", false);
                Player1Animator.SetBool("English", true);
                Player1Animator.enabled = true;

                TwoPlayerNextButtonCharacterSelection.player1UseAnimation = true;
            }
            else
            {
                Player2MoveableSprite = Resources.LoadAll<Sprite>("Character/englishidle");

                sprite = Player2MoveableSprite[0];

                Player2Animator = GameObject.Find("Player2/playerImage").GetComponent<Animator>();
                Player2Animator.SetBool("Scottish", false);
                Player2Animator.SetBool("English", true);
                Player2Animator.enabled = true;

                TwoPlayerNextButtonCharacterSelection.player2UseAnimation = true;
            }
        }
        else
        {

        }
    }

    IEnumerator nextStage()
    {
        yield return new WaitForSeconds(1);

        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer != true)
        {
            TwoPlayerNextButtonCharacterSelection.isTwoPlayer = true;
        }

        Application.LoadLevel("TwoPlayerStage");
    }
}
