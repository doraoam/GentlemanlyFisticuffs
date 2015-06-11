using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Linq;

public class SelectedCharacter : MonoBehaviour 
{
    public Sprite playerSprite;
    public Text playerText;

    public Sprite enermySprite;
    public Text enermyText;
 
    void Awake()
    {
        if (NextButtonCharacterSelection.playerImage)
        {
            playerSprite = NextButtonCharacterSelection.playerImage;
            Image Image1 = transform.Find("Player1/Image 1").GetComponent<Image>();
            Image1.sprite = playerSprite;

            enermySprite = playerSprite;

            while (enermySprite == playerSprite)
            {
                Sprite[] images = Resources.LoadAll<Sprite>("DC/");

                // if create a new Sprite variable here will found unlimit loop.
                enermySprite = images[Random.Range(0, images.Length)];
            }

            Image Image2 = transform.Find("Player2/Image2").GetComponent<Image>();
            Image2.sprite = enermySprite;
        }
        else
        {
            playerSprite = Resources.Load<Sprite>("DC/Batman-SUMPC");
            Image Image1 = transform.Find("Player1/Image 1").GetComponent<Image>();
            Image1.sprite = playerSprite;

            enermySprite = playerSprite;

            while (enermySprite == playerSprite)
            {
                Sprite[] images = Resources.LoadAll<Sprite>("DC/");

                // if create a new Sprite variable here will found unlimit loop.
                enermySprite = images[Random.Range(0, images.Length)];
            }

            Image Image2 = transform.Find("Player2/Image2").GetComponent<Image>();
            Image2.sprite = enermySprite;
        }
    }


}
