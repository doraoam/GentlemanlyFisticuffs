using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Image startText;

    // Use this for initialization
    void Start()
    {
        startText = startText.GetComponent<Image>();
    }



    public void StartLevel()
    {
        Application.LoadLevel(1);
    }

}
