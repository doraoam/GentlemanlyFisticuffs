using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    public string startLevel;

    public void StartGame()
    {
        Application.LoadLevel("CharacterSelection");
    }

    public void StartMulti()
    {
        Application.LoadLevel("Multiplayer");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
