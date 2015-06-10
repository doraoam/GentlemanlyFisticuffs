using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterName : MonoBehaviour
{
    public Text characterText;
    public string characterName;

    public void Awake()
    {
        characterText = GetComponent<Text>();
        if (characterText)
        {
            characterName = characterText.text;
        }
    }

    public void selectCharacter()
    {
        characterText = gameObject.GetComponent<Text>();
        NextButtonCharacterSelection.playerName = characterText.text;
    }
}
