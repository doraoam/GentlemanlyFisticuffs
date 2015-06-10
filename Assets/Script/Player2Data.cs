using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player2Data : MonoBehaviour
{
    public Text player2Name;

    public float maxHealth = 100;
    public static float curHealth = 100;

    public static string curAction; 

    // Use this for initialization
    void Start()
    {
        player2Name.text = "Enemy";
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1Data.curAction != "nothing")
        {
            float randValue = Random.value;
            if (randValue < .45f)
            {
                curAction = "attack";
            }
            else if (randValue >= .45f && randValue < .9f)
            {
                curAction = "defend";
            }
            else
            {
                curAction = "bluff";
            }
        }
    }
}
