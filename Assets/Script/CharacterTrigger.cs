using UnityEngine;
using System.Collections;

public class CharacterTrigger : MonoBehaviour
{
    public int playerNumber;

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
        if (col.CompareTag("Attack"))
        {
            if (playerNumber == 1)
            {
                player1Data.TakeDamage(10, "attack");  
            }
            else
            {
                player2Data.TakeDamage(10, "attack");
            }
        }
        else if (col.CompareTag("Bluff"))
        {
            if (playerNumber == 1)
            {
                player1Data.TakeDamage(10, "bluff");
            }
            else
            {
                player2Data.TakeDamage(10, "bluff");
            }
        }
    }
}
