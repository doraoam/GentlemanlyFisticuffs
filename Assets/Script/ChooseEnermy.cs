using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChooseEnermy : MonoBehaviour
{
    public Sprite player2Sprite;
    public Text player2Text;

    void Start()
    {
        player2Sprite = Resources.Load<Sprite>("DC/Batman-SUMPC");
        Image Image = transform.Find("Player2/playerImage").GetComponent<Image>();
        Image.sprite = player2Sprite;

        Text text = transform.Find("Player2/Player2Text").GetComponent<Text>();
        text.text = "Please wait";
    }

    void Update()
    {
        if (NextButtonCharacterSelection.player2Name != null)
        {
            if (NextButtonCharacterSelection.player2Name == "Batman")
            {
                player2Sprite = Resources.Load<Sprite>("DC/Batman-SUMPC");
            }
            else if (NextButtonCharacterSelection.player2Name == "Robin")
            {
                player2Sprite = Resources.Load<Sprite>("DC/Robin-SUMPC");
            }
            else if (NextButtonCharacterSelection.player2Name == "Maxwell")
            {
                player2Sprite = Resources.Load<Sprite>("DC/Maxwell");
            }
            else if (NextButtonCharacterSelection.player2Name == "Superman")
            {
                player2Sprite = Resources.Load<Sprite>("DC/Superman-SUMPC");
            }
            else if (NextButtonCharacterSelection.player2Name == "Green Lantern")
            {
                player2Sprite = Resources.Load<Sprite>("DC/Green_Lantern_Hal_Jordan");
            }
            else if (NextButtonCharacterSelection.player2Name == "Jeve Stob")
            {
                player2Sprite = Resources.Load<Sprite>("DC/Andrew_Warthen");
            }
            else if (NextButtonCharacterSelection.player2Name == "Joker")
            {
                player2Sprite = Resources.Load<Sprite>("DC/Joker_Dc");
            }
            else if (NextButtonCharacterSelection.player2Name == "Penguin")
            {
                player2Sprite = Resources.Load<Sprite>("DC/Villain_Female");
            }
            else if (NextButtonCharacterSelection.player2Name == "Storm trooper")
            {
                player2Sprite = Resources.Load<Sprite>("DC/Nathan_Hernandez_SnU");
            }
            else if (NextButtonCharacterSelection.player2Name == "Brady")
            {
                player2Sprite = Resources.Load<Sprite>("DC/Brady_Houck");
            }
            else if (NextButtonCharacterSelection.player2Name == "Knight")
            {
                player2Sprite = Resources.Load<Sprite>("DC/Knight_(Male)");
            }
            else if (NextButtonCharacterSelection.player2Name == "Sandman")
            {
                player2Sprite = Resources.Load<Sprite>("DC/Sandman");
            }

            Image Image = transform.Find("Player2/playerImage").GetComponent<Image>();
            Image.sprite = player2Sprite;
            NextButtonCharacterSelection.player2Image = player2Sprite;

            Text text = transform.Find("Player2/Player2Text").GetComponent<Text>();
            text.text = NextButtonCharacterSelection.player2Name;
        }
    }
}
