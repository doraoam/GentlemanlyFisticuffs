using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChoosePlayer : MonoBehaviour
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

    void Update()
    {
        if (NextButtonCharacterSelection.playerName != null)
        {
            if (NextButtonCharacterSelection.playerName == "Batman")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Batman-SUMPC");
            }
            else if (NextButtonCharacterSelection.playerName == "Robin")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Robin-SUMPC");
            }
            else if (NextButtonCharacterSelection.playerName == "Maxwell")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Maxwell");
            }
            else if (NextButtonCharacterSelection.playerName == "Superman")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Superman-SUMPC");
            }
            else if (NextButtonCharacterSelection.playerName == "Green Lantern")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Green_Lantern_Hal_Jordan");
            }
            else if (NextButtonCharacterSelection.playerName == "Jeve Stob")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Andrew_Warthen");
            }
            else if (NextButtonCharacterSelection.playerName == "Joker")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Joker_Dc");
            }
            else if (NextButtonCharacterSelection.playerName == "Penguin")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Villain_Female");
            }
            else if (NextButtonCharacterSelection.playerName == "Storm trooper")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Nathan_Hernandez_SnU");
            }
            else if (NextButtonCharacterSelection.playerName == "Brady")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Brady_Houck");
            }
            else if (NextButtonCharacterSelection.playerName == "Knight")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Knight_(Male)");
            }
            else if (NextButtonCharacterSelection.playerName == "Sandman")
            {
                player1Sprite = Resources.Load<Sprite>("DC/Sandman");
            }

            Image Image = transform.Find("Player1/playerImage").GetComponent<Image>();
            Image.sprite = player1Sprite;
            NextButtonCharacterSelection.playerImage = player1Sprite;

            Text text = transform.Find("Player1/Player1Text").GetComponent<Text>();
            text.text = NextButtonCharacterSelection.playerName;
        }
    }
}
