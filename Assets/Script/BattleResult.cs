using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BattleResult : MonoBehaviour
{
    public Text resultText;

    GameObject player1;
    GameObject player2;

    Player1Data player1Data;
    Player2Data player2Data;

    Animator player1Animator;
    Animator player2Animator;

    // Use this for initialization
    void Start()
    {
        resultText.text = "result";

        player1 = GameObject.FindGameObjectWithTag("Player1Data");
        player2 = GameObject.FindGameObjectWithTag("Player2Data");

        player1Data = player1.GetComponent<Player1Data>();
        player2Data = player2.GetComponent<Player2Data>();

        if (NextButtonCharacterSelection.player1UseAnimation || TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
        {
            player1Animator = GameObject.FindGameObjectWithTag("Player1Animator").GetComponent<Animator>();
        }

        if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
        {
            player2Animator = GameObject.FindGameObjectWithTag("Player2Animator").GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1Data.curAction == "attack" && Player2Data.curAction == "bluff" || Player1Data.curAction == "bluff" && Player2Data.curAction == "defend")
        {
            player2Data.TakeDamage(10, Player1Data.curAction);

            resultText.text = "Player 1 get point!";
        }
        else if (Player1Data.curAction == "bluff" && Player2Data.curAction == "attack" || Player1Data.curAction == "defend" && Player2Data.curAction == "bluff")
        {
            player1Data.TakeDamage(10, Player2Data.curAction);

            resultText.text = "Player 2 get point!";
        }
        else if (Player1Data.curAction == "attack" && Player2Data.curAction == "attack" || Player1Data.curAction == "bluff" && Player2Data.curAction == "bluff")
        {
            player1Data.TakeDamage(10, Player2Data.curAction);
            player2Data.TakeDamage(10, Player1Data.curAction);

            resultText.text = "Both get hurt";
        }
        else
        {
            //resultText.text = "Nothing happen.";
        }
            //if (NextButtonCharacterSelection.player1UseAnimation || TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
            //{
            //    if (!player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1PunchDamageAnimation") && !player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BluffDamageAnimation"))
            //    {
            //        player1Controller();
            //    }
            //    else
            //    {
            //        if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BluffDamageAnimation"))
            //        {
            //            player1Animator.SetBool("Bluffed", false);
            //        }

            //        if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1PunchDamageAnimation"))
            //        {
            //            player1Animator.SetBool("Punched", false);
            //        }
            //    }
            //}
            
            //if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
            //{
            //    if (!player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2PunchDamageAnimation") && !player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2BluffDamageAnimation"))
            //    {
            //        player2Controller();
            //    }
            //    else
            //    {
            //        if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2BluffDamageAnimation"))
            //        {
            //            player2Animator.SetBool("Bluffed", false);
            //        }

            //        if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2PunchDamageAnimation"))
            //        {
            //            player2Animator.SetBool("Punched", false);
            //        }
            //    }
            //}

    }

    //void player1Controller()
    //{
    //    if (Player1Data.curAction == "attack")
    //    {
    //        player1Animator.SetBool("Punch", true);
    //        player1Animator.SetBool("Block", false);
    //        player1Animator.SetBool("Bluff", false);
    //    }
    //    else if (Player1Data.curAction == "defend")
    //    {
    //        player1Animator.SetBool("Punch", false);
    //        player1Animator.SetBool("Block", true);
    //        player1Animator.SetBool("Bluff", false);
    //    }
    //    else if (Player1Data.curAction == "bluff")
    //    {
    //        player1Animator.SetBool("Punch", false);
    //        player1Animator.SetBool("Block", false);
    //        player1Animator.SetBool("Bluff", true);
    //    }
    //    else
    //    {
    //        //if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1PunchAnimation"))
    //        //{
    //        //    player1Animator.SetBool("Punch", false);
    //        //}

    //        //if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BlockAnimation"))
    //        //{
    //        //    player1Animator.SetBool("Block", false);
    //        //}

    //        //if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BluffAnimation"))
    //        //{
    //        //    player1Animator.SetBool("Bluff", false);
    //        //}
    //    }
    //}

    //void player2Controller()
    //{
    //    if (Player2Data.curAction == "attack")
    //    {
    //        player2Animator.SetBool("Punch", true);
    //        player2Animator.SetBool("Block", false);
    //        player2Animator.SetBool("Bluff", false);
    //    }
    //    else if (Player2Data.curAction == "defend")
    //    {
    //        player2Animator.SetBool("Punch", false);
    //        player2Animator.SetBool("Block", true);
    //        player2Animator.SetBool("Bluff", false);
    //    }
    //    else if (Player2Data.curAction == "bluff")
    //    {
    //        player2Animator.SetBool("Punch", false);
    //        player2Animator.SetBool("Block", false);
    //        player2Animator.SetBool("Bluff", true);
    //    }
    //    else
    //    {
    //        //if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2PunchAnimation"))
    //        //{
    //        //    player2Animator.SetBool("Punch", false);
    //        //}

    //        //if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2BlockAnimation"))
    //        //{
    //        //    player2Animator.SetBool("Block", false);
    //        //}

    //        //if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2BluffAnimation"))
    //        //{
    //        //    player2Animator.SetBool("Bluff", false);
    //        //}
    //    }    
    //}
}
