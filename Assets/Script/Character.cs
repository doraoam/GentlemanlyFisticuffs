using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public Image characterImage;
    public Sprite characterSprite;

    public void Awake()
    {
        characterImage = GetComponent<Image>();
        if(characterImage)
        {
            characterSprite = characterImage.sprite;
        }
    }
    void Start()
    {
        //if (characterSprite != null)
        //{
        //    characterImage.sprite = characterSprite;
        //    Debug.Log(characterSprite);
        //}
        //else
        //{
        //    characterSprite = Resources.Load<Sprite>("Batman-SUMPC.png");
        //    if (characterSprite != null)
        //    {
        //        characterImage.sprite = characterSprite;
        //        Debug.Log(characterSprite);
        //    }
        //    else
        //        Debug.Log(characterSprite,this);
        //}
    }

    // Update is called once per frame
    public void selectCharacter()
    {
        characterSprite = gameObject.GetComponent<Image>().sprite;
        NextButtonCharacterSelection.playerImage = characterSprite;
    }
}
