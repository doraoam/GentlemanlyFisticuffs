using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player1Data : MonoBehaviour
{
    public Text player1Name;

    public float maxHealth = 100;
    public static float curHealth = 100;

    public static string curAction;

    // Use this for initialization
    public void Awake()
    {
        if (NextButtonCharacterSelection.playerImage)
        {
            player1Name.text = NextButtonCharacterSelection.playerName;
        }
        else
        {
            player1Name.text = "batman";
        }
        curAction = "nothing";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            curAction = "attack";
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            curAction = "defend";
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            curAction = "bluff";
        }
        else
        {
            curAction = "nothing";
        }
    }
}
