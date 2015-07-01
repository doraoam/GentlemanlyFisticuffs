using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BattleResult : MonoBehaviour
{
    public Text resultText;

    GameObject player1;
    GameObject player2;

    Player1Data player1Data;
    Player2Data player2Data;

    Animator player1Animator;
    Animator player2Animator;

    // Use this for initialization
    void Start()
    {
        resultText.text = "result";

        player1 = GameObject.FindGameObjectWithTag("Player1Data");
        player2 = GameObject.FindGameObjectWithTag("Player2Data");

        player1Data = player1.GetComponent<Player1Data>();
        player2Data = player2.GetComponent<Player2Data>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1Data.curAction != "nothing")
        {
            if (Player1Data.curAction == "attack" && Player2Data.curAction == "bluff" || Player1Data.curAction == "bluff" && Player2Data.curAction == "defend")
            {
                player2Data.TakeDamage(10,Player1Data.curAction);

                resultText.text = "Player 1 get point!";
            }
            else if (Player1Data.curAction == "bluff" && Player2Data.curAction == "attack" || Player1Data.curAction == "defend" && Player2Data.curAction == "bluff")
            {
                player1Data.TakeDamage(10,Player2Data.curAction);

                resultText.text = "Player 2 get point!";
            }
            else if(Player1Data.curAction == "attack" && Player2Data.curAction == "attack" || Player1Data.curAction == "bluff" && Player2Data.curAction == "bluff")
            {
                player1Data.TakeDamage(10,Player2Data.curAction);
                player2Data.TakeDamage(10,Player1Data.curAction);
                
                resultText.text = "Both get hurt";
            }
            else
            {
                resultText.text = "Nothing happen.";
            }
        }
    }
}
