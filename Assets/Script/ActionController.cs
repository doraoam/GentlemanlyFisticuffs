using UnityEngine;
using System.Collections;

public class ActionController : MonoBehaviour
{
    GameObject player1;
    GameObject player2;

    Player1Data player1Data;
    Player2Data player2Data;

    void Awake()
    {
        player1 = GameObject.FindGameObjectWithTag("Player1Data");
        player2 = GameObject.FindGameObjectWithTag("Player2Data");

        player1Data = player1.GetComponent<Player1Data>();
        player2Data = player2.GetComponent<Player2Data>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player1Scottish" || col.tag == "Player1English")
        {
            Debug.Log("Player2Enter");
            if (Player1Data.curAction == "attack")
            {
                if (Player2Data.curAction == "attack")
                {
                    player1Data.TakeDamage(10, Player2Data.curAction);
                    player2Data.TakeDamage(10, Player1Data.curAction);
                }
            }
            else if (Player1Data.curAction == "defend")
            {
                if (Player2Data.curAction == "bluff")
                {
                    player1Data.TakeDamage(10, Player2Data.curAction);
                }
            }
            else if (Player1Data.curAction == "bluff")
            {
                if (Player2Data.curAction == "attack")
                {
                    player1Data.TakeDamage(10, Player2Data.curAction);
                }
                else if (Player2Data.curAction == "bluff")
                {
                    player1Data.TakeDamage(10, Player2Data.curAction);
                    player2Data.TakeDamage(10, Player1Data.curAction);
                }
            }
        }
        else if (col.tag == "Player2Scottish" || col.tag == "Player2English")
        {
            Debug.Log("Player1Enter");
            if (Player2Data.curAction == "attack")
            {
                if (Player1Data.curAction == "attack")
                {
                    player2Data.TakeDamage(10, Player1Data.curAction);
                    player1Data.TakeDamage(10, Player2Data.curAction);
                }
            }
            else if (Player2Data.curAction == "defend")
            {
                if (Player1Data.curAction == "bluff")
                {
                    player2Data.TakeDamage(10, Player1Data.curAction);
                }
            }
            else if (Player2Data.curAction == "bluff")
            {
                if (Player1Data.curAction == "attack")
                {
                    player2Data.TakeDamage(10, Player1Data.curAction);
                }
                else if (Player1Data.curAction == "bluff")
                {
                    player2Data.TakeDamage(10, Player1Data.curAction);
                    player1Data.TakeDamage(10, Player2Data.curAction);
                }
            }
        }
    }

}
