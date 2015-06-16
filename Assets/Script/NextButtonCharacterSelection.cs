using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class NextButtonCharacterSelection : MonoBehaviour
{
    public static Sprite playerImage;
    public static string playerName;

    public static Sprite player2Image;
    public static string player2Name;

    public static bool enablePlayer1;
    public static bool enablePlayer2;

    void Awake()
    {

    }

    public void Next()
    {
        Application.LoadLevel("test");

        GameOver.isOver = false;
    }
}
