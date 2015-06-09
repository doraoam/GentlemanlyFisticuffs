using UnityEngine;
using System.Collections;

public class LevelSelectManager : MonoBehaviour
{

    public Animator ResumeText;
    public Animator ResumeButton;
    public Animator LevelButton;
    public Animator MainMenuButton;

    public void OpenLevel()
    {
        ResumeText.SetBool("isHidden", true);
        ResumeButton.SetBool("isHidden", true);
        LevelButton.SetBool("isHidden", true);
        MainMenuButton.SetBool("isHidden", true);
    }
}
