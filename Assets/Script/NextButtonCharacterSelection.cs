using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class NextButtonCharacterSelection : MonoBehaviour
{
    public static Sprite playerImage;
    public static string playerName;

    void Awake()
    {

    }

    public void Next()
    {
        Application.LoadLevel("test");

        GameOver.isOver = false;
    }
}
