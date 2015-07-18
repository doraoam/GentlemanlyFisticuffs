using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TwoPlayerChooseCharacter : MonoBehaviour
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
        TwoPlayerNextButtonCharacterSelection.enablePlayer1 = true;

        enablePlayer2 = false;
    }

    public void onClick()
    {
        if (TwoPlayerNextButtonCharacterSelection.enablePlayer1 == true)
        {
            player1Text = GetComponent<Text>();
            TwoPlayerNextButtonCharacterSelection.player1Name = player1Text.text;

            enablePlayer2 = true;
            TwoPlayerNextButtonCharacterSelection.enablePlayer2 = enablePlayer2;
            
            enablePlayer1 = false;
            TwoPlayerNextButtonCharacterSelection.enablePlayer1 = enablePlayer1;
        }
        else if(TwoPlayerNextButtonCharacterSelection.enablePlayer2 == true)
        {
            player2Text = GetComponent<Text>();
            TwoPlayerNextButtonCharacterSelection.player2Name = player2Text.text;
            
            enablePlayer2 = false;
            TwoPlayerNextButtonCharacterSelection.enablePlayer2 = enablePlayer2;
        }

        if (TwoPlayerNextButtonCharacterSelection.enablePlayer1 == TwoPlayerNextButtonCharacterSelection.enablePlayer2)
        {
            //StartCoroutine(nextStage());

            if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer != true)
            {
                TwoPlayerNextButtonCharacterSelection.isTwoPlayer = true;
            }

            Application.LoadLevel("StageSelect");
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
