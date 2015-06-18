using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused;

    public GameObject pauseMenuCanvas;

    public GameObject resumeButton;

    // Update is called once per frame
    void Update()
    {
        if (isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetButtonDown("Pause"))
        {
            isPaused = !isPaused;
            EventSystem.current.SetSelectedGameObject(resumeButton);
        }
    }

    public void Resume()
    {
        isPaused = false;
    }

    public void LevelSelect()
    {
        Application.LoadLevel("StageSelect");
    }

    public void Home()
    {
        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer)
        {
            TwoPlayerNextButtonCharacterSelection.isTwoPlayer = false;

            TwoPlayerNextButtonCharacterSelection.enablePlayer1 = true;
            TwoPlayerNextButtonCharacterSelection.enablePlayer2 = true;

            TwoPlayerNextButtonCharacterSelection.player1Image = null;
            TwoPlayerNextButtonCharacterSelection.player1Name = null;

            TwoPlayerNextButtonCharacterSelection.player2Image = null;
            TwoPlayerNextButtonCharacterSelection.player2Name = null;
        }
        else
        {
            NextButtonCharacterSelection.enablePlayer1 = true;
            NextButtonCharacterSelection.enablePlayer2 = true;

            NextButtonCharacterSelection.playerImage = null;
            NextButtonCharacterSelection.playerName = null;

            NextButtonCharacterSelection.player2Image = null;
            NextButtonCharacterSelection.player2Name = null;
        }

        isPaused = false;

        Application.LoadLevel("Mainmenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
