using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameOver : MonoBehaviour {

    public Text resultText;

    public static bool isOver;

    public GameObject gameOverCanvas;

    public GameObject HomeButton;

    void Start()
    {
        isOver = false;
    }

    // Update is called once per frame
    public void Update()
    {
        if (isOver == true)
        {
            gameOverCanvas.SetActive(true);

            if (Player1Data.curAction == "Death" )
            {
                resultText.text = "Player 2 win!!";
            }
            else if (Player2Data.curAction == "Death" )
            {
                resultText.text = "Player 1 win!!";
            }
            else
            {
                resultText.text = "Time out!!";
                  //+ " " + "Programmer win!!!";
            }

            Time.timeScale = 1;

            EventSystem.current.SetSelectedGameObject(HomeButton);
        }
        else
        {
            gameOverCanvas.SetActive(false);

            if (PauseMenu.isPaused != true)
            {
                Time.timeScale = 1f;
            }
            else
            {
                Time.timeScale = 0;
            }
        }
    }
}
