using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TwoPlayerSelectCharacter : MonoBehaviour
{
    public Sprite player1Sprite;
    public Text player1Text;

    void Start()
    {
        player1Sprite = Resources.Load<Sprite>("DC/Joker_DC");
        Image Image = transform.Find("Player1/playerImage").GetComponent<Image>();
        Image.sprite = player1Sprite;

        Text text = transform.Find("Player1/Player1Text").GetComponent<Text>();
        text.text = "Please wait";
    }

    void Update(){
        if (TwoPlayerNextButtonCharacterSelection.player1Name != null)
        {
            if (TwoPlayerNextButtonCharacterSelection.player1Name == "Batman")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Batman-SUMPC");
            }
            else if (TwoPlayerNextButtonCharacterSelection.player1Name == "Robin")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Robin-SUMPC");
            }
            else if (TwoPlayerNextButtonCharacterSelection.player1Name == "Maxwell")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Maxwell");
            }
            else if (TwoPlayerNextButtonCharacterSelection.player1Name == "Superman")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Superman-SUMPC");
            }
            else if (TwoPlayerNextButtonCharacterSelection.player1Name == "Green Lantern")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Green_Lantern_Hal_Jordan");
            }
            else if (TwoPlayerNextButtonCharacterSelection.player1Name == "Jeve Stob")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Andrew_Warthen");
            }
            else if (TwoPlayerNextButtonCharacterSelection.player1Name == "Joker")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Joker_Dc");
            }
            else if (TwoPlayerNextButtonCharacterSelection.player1Name == "Penguin")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Villain_Female");
            }
            else if (TwoPlayerNextButtonCharacterSelection.player1Name == "Storm trooper")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Nathan_Hernandez_SnU");
            }
            else if (TwoPlayerNextButtonCharacterSelection.player1Name == "Brady")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Brady_Houck");
            }
            else if (TwoPlayerNextButtonCharacterSelection.player1Name == "Knight")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Knight_(Male)");
            }
            else if (TwoPlayerNextButtonCharacterSelection.player1Name == "Sandman")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Sandman");
            }

            Image Image = transform.Find("Player1/playerImage").GetComponent<Image>();
            Image.sprite = player1Sprite;
            TwoPlayerNextButtonCharacterSelection.player1Image = player1Sprite;

            Text text = transform.Find("Player1/Player1Text").GetComponent<Text>();
            text.text = TwoPlayerNextButtonCharacterSelection.player1Name;

        }
    }
}
