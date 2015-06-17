using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChooseCharacter : MonoBehaviour
{
    public Text player1Text;
    public Text player2Text;

    public string player1Name;
    public string player2Name;

    public bool enablePlayer1;
    public bool enablePlayer2;

    void Awake()
    {
        enablePlayer1 = true;
        NextButtonCharacterSelection.enablePlayer1 = true;

        enablePlayer2 = false;
    }

    public void onClick()
    {
        if (NextButtonCharacterSelection.enablePlayer1 == true)
        {
            player1Text = GetComponent<Text>();
            NextButtonCharacterSelection.playerName = player1Text.text;

            enablePlayer2 = true;
            NextButtonCharacterSelection.enablePlayer2 = enablePlayer2;

            enablePlayer1 = false;
            NextButtonCharacterSelection.enablePlayer1 = enablePlayer1;
        }
        else if (NextButtonCharacterSelection.enablePlayer2 == true)
        {
            player2Text = GetComponent<Text>();
            NextButtonCharacterSelection.player2Name = player2Text.text;

            enablePlayer2 = false;
            NextButtonCharacterSelection.enablePlayer2 = enablePlayer2;
        }

        if (NextButtonCharacterSelection.enablePlayer1 == NextButtonCharacterSelection.enablePlayer2)
        {
            //StartCoroutine(nextStage());

            Application.LoadLevel("test");
        }
    }

    IEnumerator nextStage()
    {
        yield return new WaitForSeconds(1);

        Application.LoadLevel("test");
    }
}
