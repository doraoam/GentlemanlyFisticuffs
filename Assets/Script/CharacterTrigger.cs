using UnityEngine;
using System.Collections;

public class CharacterTrigger : MonoBehaviour
{
    public int playerNumber;

    GameObject player1;
    GameObject player2;

    Player1Data player1Data;
    Player2Data player2Data;

    bool defending;
    bool triggered;

    Collider2D other;

    void Awake()
    {
        player1 = GameObject.FindGameObjectWithTag("Player1Data");
        player2 = GameObject.FindGameObjectWithTag("Player2Data");

        player1Data = player1.GetComponent<Player1Data>();
        player2Data = player2.GetComponent<Player2Data>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        triggered = true;
        this.other = col;

        if (GameOver.isOver != true)
        {
            if (col.CompareTag("Block"))
            {
                defending = true;
            }
            else
            {
                if (!defending)
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
                    if (col.CompareTag("Bluff"))
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
                else
                {
                    if (col.CompareTag("Bluff"))
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

                    defending = false;
                }
            }
        }
    }

    void Update()
    {
        if (triggered && !other)
        {
            defending = false;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Block"))
        {
            defending = true;
        }
    }
}
