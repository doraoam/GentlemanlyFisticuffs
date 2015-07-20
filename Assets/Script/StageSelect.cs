using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StageSelect : MonoBehaviour
{
    Sprite background;

    public Text text;

    void Awake()
    {
     
    }


    public void onClick()
    {
        Image image = GetComponent<Image>();
        background = image.sprite;

        text = GetComponentInChildren<Text>();

        GameObject stageBackground = new GameObject();
        stageBackground.transform.tag = "Background";

        SpriteRenderer spriteRenderer = stageBackground.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = background;

        DontDestroyOnLoad(stageBackground);

        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer)
        {
            TwoPlayerNextButtonCharacterSelection.backgroundImage = background;
            TwoPlayerNextButtonCharacterSelection.backgroundName = text.text;
           
            Application.LoadLevel("TwoPlayerStage");
        }
        else
        {
            NextButtonCharacterSelection.backgroundImage = background;
            NextButtonCharacterSelection.backgroundName = text.text;

            Application.LoadLevel("test");
        }
    }
}
