using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomCharacter : MonoBehaviour
{
    string player1Name;
    string player2Name;

    string stageName;
    Image stageImage;
    Sprite stageSprite;

    Sprite sprite;
    Sprite sprite2;

    Sprite[] Player1MoveableSprite;
    Sprite[] Player2MoveableSprite;

    Animator Player1Animator;
    Animator Player2Animator;

    public void onClickRandom()
    {
        string[] name = new string[] { "Scottish", "English" };

        if (NextButtonCharacterSelection.playerName != null)
        {
            
        }
        else
        {
            player1Name = name[Random.Range(0, name.Length - 1)];

            chooseCharacter(player1Name,1);

            Text text = transform.Find("Player1/Player1Text").GetComponent<Text>();
            text.text = player1Name;
            NextButtonCharacterSelection.playerName = player1Name;

            NextButtonCharacterSelection.enablePlayer1 = false;
        }

        player2Name = name[Random.Range(0, name.Length - 1)];

        chooseCharacter(player2Name, 2);

        Text text2 = transform.Find("Player2/Player2Text").GetComponent<Text>();
        text2.text = player2Name;
        NextButtonCharacterSelection.player2Name = player2Name;

        NextButtonCharacterSelection.enablePlayer2 = false;
        
        Application.LoadLevel("StageSelect");
    }

    void chooseCharacter(string name,int playerNumber)
    {
        if (name == "Scottish")
        {
            if (playerNumber == 1)
            {
                Player1MoveableSprite = Resources.LoadAll<Sprite>("Character/scottishidle");

                sprite = Player1MoveableSprite[0];

                Player1Animator = GameObject.Find("Player1/playerImage").GetComponent<Animator>();
                Player1Animator.SetBool("Scottish", true);
                Player1Animator.SetBool("English", false);
                Player1Animator.enabled = true;

                NextButtonCharacterSelection.player1UseAnimation = true;
            }
            else
            {
                Player2MoveableSprite = Resources.LoadAll<Sprite>("Character/scottishidle");

                sprite = Player2MoveableSprite[0];

                Player2Animator = GameObject.Find("Player2/playerImage").GetComponent<Animator>();
                Player2Animator.SetBool("Scottish", true);
                Player2Animator.SetBool("English",false);
                Player2Animator.enabled = true;

                NextButtonCharacterSelection.player2UseAnimation = true;
            }
        }
        else if (name == "English")
        {
            if (playerNumber == 1)
            {
                Player1MoveableSprite = Resources.LoadAll<Sprite>("Character/englishidle");

                sprite = Player1MoveableSprite[0];

                Player1Animator = GameObject.Find("Player1/playerImage").GetComponent<Animator>();
                Player1Animator.SetBool("Scottish", false);
                Player1Animator.SetBool("English",true);
                Player1Animator.enabled = true;

                NextButtonCharacterSelection.player1UseAnimation = true;
            }
            else
            {
                Player2MoveableSprite = Resources.LoadAll<Sprite>("Character/englishidle");

                sprite = Player2MoveableSprite[0];

                Player2Animator = GameObject.Find("Player2/playerImage").GetComponent<Animator>();
                Player2Animator.SetBool("Scottish", false);
                Player2Animator.SetBool("English", true);
                Player2Animator.enabled = true;

                NextButtonCharacterSelection.player2UseAnimation = true;
            }
        }
        else
        {
            
        }
    }

    IEnumerator nextStage()
    {
        yield return new WaitForSeconds(1);

        Application.LoadLevel("StageSelect");
    }

    public void stageOnClick()
    {
        string[] stage = new string[] { "Scotland", "England", "IrishPub" };
        stageName = stage[Random.Range(0, stage.Length)];
        
        if (stageName == "Scotland")
        {
            stageSprite = Resources.Load<Sprite>("Background/Scot/BGScot1");
        }
        else if (stageName == "England")
        {
            stageSprite = Resources.Load<Sprite>("Background/English/BGEnglish1");
        }
        else
        {
            stageSprite = Resources.Load<Sprite>("Background/Irish/irirsPub1");
        }

        GameObject stageBackground = new GameObject();
        stageBackground.transform.tag = "Background";

        SpriteRenderer spriteRenderer = stageBackground.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = stageSprite;

        DontDestroyOnLoad(stageBackground);

        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer)
        {
            TwoPlayerNextButtonCharacterSelection.backgroundImage = stageSprite;
            TwoPlayerNextButtonCharacterSelection.backgroundName = stageName;

            Application.LoadLevel("TwoPlayerStage");
        }
        else
        {
            NextButtonCharacterSelection.backgroundImage = stageSprite;
            NextButtonCharacterSelection.backgroundName = stageName;

            Application.LoadLevel("test");
        }
    }
}
