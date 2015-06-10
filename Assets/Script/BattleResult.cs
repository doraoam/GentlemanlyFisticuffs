using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BattleResult : MonoBehaviour
{
    public Text resultText;

    // Use this for initialization
    void Start()
    {
        resultText.text = "result";
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1Data.curAction != "nothing")
        {
            if (Player1Data.curAction == "attack" && Player2Data.curAction == "bluff")
            {
                Player2Data.curHealth -= 5;
                resultText.text = "Player 1 get point!";
            }
            else if (Player2Data.curAction == "attack" && Player1Data.curAction == "bluff")
            {
                Player1Data.curHealth -= 5;
                resultText.text = "Player 2 get point!";
            }
            else if(Player1Data.curAction == "attack" && Player2Data.curAction == "attack")
            {
                Player1Data.curHealth -= 5;
                Player2Data.curHealth -= 5;
                resultText.text = "Both get hurt";
            }
            else
            {
                resultText.text = "Nothing happen.";
            }

            Debug.Log("Player1: " + Player1Data.curAction);
            Debug.Log("Player2: " + Player2Data.curAction);
        }
    }
}
