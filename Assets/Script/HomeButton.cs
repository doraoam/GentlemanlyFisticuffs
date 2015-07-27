using UnityEngine;
using System.Collections;

public class HomeButton : MonoBehaviour
{

    public void Home()
    {
        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer)
        {
            TwoPlayerNextButtonCharacterSelection.isTwoPlayer = false;

            TwoPlayerNextButtonCharacterSelection.enablePlayer1 = true;
            TwoPlayerNextButtonCharacterSelection.enablePlayer2 = true;

            TwoPlayerNextButtonCharacterSelection.player1Image = null;
            TwoPlayerNextButtonCharacterSelection.player1Name = null;

            TwoPlayerNextButtonCharacterSelection.player2Image = null;
            TwoPlayerNextButtonCharacterSelection.player2Name = null;
        }
        else
        {
            NextButtonCharacterSelection.enablePlayer1 = true;
            NextButtonCharacterSelection.enablePlayer2 = true;

            NextButtonCharacterSelection.playerImage = null;
            NextButtonCharacterSelection.playerName = null;

            NextButtonCharacterSelection.player2Image = null;
            NextButtonCharacterSelection.player2Name = null;
        }
        
        Application.LoadLevel("Mainmenu");
    }
}
