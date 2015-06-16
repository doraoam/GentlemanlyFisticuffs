using UnityEngine;
using System.Collections;

public class ReplayButton : MonoBehaviour
{

    public void rePlay()
    {
        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer != true)
        {
            Application.LoadLevel("test");
        }
        else
        {
            Application.LoadLevel("TwoPlayerStage");
        }
    }
}
