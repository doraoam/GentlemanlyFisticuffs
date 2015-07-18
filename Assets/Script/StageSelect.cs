using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StageSelect : MonoBehaviour
{
    Sprite background;

    public Text text;

    public void onClick()
    {
        Image image = GetComponent<Image>();
        background = image.sprite;

        text = GetComponentInChildren<Text>();
        
        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer)
        {
            TwoPlayerNextButtonCharacterSelection.backgroundImage = background;
            TwoPlayerNextButtonCharacterSelection.backgroundName = text.text;

            Application.LoadLevel("TwoPlayerStage");
        }
        else
        {
            NextButtonCharacterSelection.backgroundImage = background;
            NextButtonCharacterSelection.backgroundName = text.text;

            Application.LoadLevel("test");
        }
    }
}
