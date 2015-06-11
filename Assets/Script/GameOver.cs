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
            Debug.Log("OK");

            gameOverCanvas.SetActive(true);

            if (Player1Data.curAction == "Death")
            {
                resultText.text = "Player 2 win!!";
            }
            else if (Player2Data.curAction == "Death")
            {
                resultText.text = "Player 1 win!!";
            }
            else if (Timer.timer <= 0)
            {
                resultText.text = "Time out!! " + "Programmer win!!!";
            }

            Time.timeScale = 0;
        }
        else
        {
            gameOverCanvas.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
