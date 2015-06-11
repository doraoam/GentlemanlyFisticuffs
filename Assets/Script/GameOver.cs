using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    public static bool isOver;

    public GameObject gameOverCanvas;

    // Update is called once per frame
    void Update()
    {
        if (isOver)
        {
            gameOverCanvas.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            gameOverCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Player1Data.curAction == "Death" || Player2Data.curAction == "Death")
        {
            isOver = !isOver;
        }
    }
}
