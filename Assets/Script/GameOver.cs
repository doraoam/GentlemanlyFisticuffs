using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public Text resultText;

    public static bool isOver;

    public GameObject gameOverCanvas;

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

            if (Player1Data.curAction == "Death" || Player1Data.isDead)
            {
                resultText.text = "Player 2 win!!";
            }
            else if (Player2Data.curAction == "Death" || Player2Data.isDead)
            {
                resultText.text = "Player 1 win!!";
            }
            else
            {
                resultText.text = "Time out!!";
                  //+ " " + "Programmer win!!!";
            }

            Time.timeScale = 0;
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
