using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectedCharacter : MonoBehaviour 
{
    public Sprite playerSprite;
    public Text playerText;
 
    void Awake()
    {
        if (NextButtonCharacterSelection.playerImage)
        {
            playerSprite = NextButtonCharacterSelection.playerImage;
            Image Image1 = transform.Find("Image 1").GetComponent<Image>();
            Image1.sprite = playerSprite;
        }
        else
        {
            playerSprite = Resources.Load<Sprite>("Batman-SUMPC");
            Image Image1 = transform.Find("Image 1").GetComponent<Image>();
            Image1.sprite = playerSprite;
        }
    }


}
