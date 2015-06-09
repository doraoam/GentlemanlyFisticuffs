using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour
{
    public string startLevel;
    public string levelSelect;

    public void StartGame()
    {
        Application.LoadLevel(1);
    }

    public void LevelSelect()
    {
        Application.LoadLevel(levelSelect);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
