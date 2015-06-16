using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused;

    public GameObject pauseMenuCanvas;

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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
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
        Application.LoadLevel("Mainmenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
