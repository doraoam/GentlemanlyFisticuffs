using UnityEngine;
using System.Collections;

public class TwoPlayerNextButtonCharacterSelection : MonoBehaviour
{
    public static Sprite player1Image;
    public static string player1Name;

    public static Sprite player2Image;
    public static string player2Name;

    public static bool isTwoPlayer;

    public static bool enablePlayer1;
    public static bool enablePlayer2;

    public static bool player1UseAnimation;
    public static bool player2UseAnimation;

    void Awake()
    {

    }

    public void Next()
    {
        Application.LoadLevel(1);

        GameOver.isOver = false;
    }
}
