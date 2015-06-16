using UnityEngine;
using System.Collections;

public class TwoPlayer : MonoBehaviour
{
    public bool isTwoPlayer;

    void Start()
    {
        isTwoPlayer = false;
    }    

    public void onClick()
    {
        isTwoPlayer = true;
        TwoPlayerNextButtonCharacterSelection.isTwoPlayer = true;
        Application.LoadLevel("TwoPlayerCharacterSelection");
    }
}
