using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player1Data : MonoBehaviour
{
    public Text player1Name;
    public Text showAction;
    

    public Animator player1Animator;

    public float maxHealth = 100;
    public float curHealth;

    public Slider healthSlider;

    public static string curAction;

    public static bool isDead;

    // Use this for initialization
    public void Awake()
    {
        if (NextButtonCharacterSelection.playerImage)
        {
            player1Name.text = NextButtonCharacterSelection.playerName;
        }else if(TwoPlayerNextButtonCharacterSelection.isTwoPlayer){
            player1Name.text = TwoPlayerNextButtonCharacterSelection.player1Name;
        }
        else
        {
            player1Name.text = "batman";
        }
        curAction = "nothing";
        showAction.text = "Nothing";

        curHealth = maxHealth;

        isDead = false;

        if (NextButtonCharacterSelection.player1UseAnimation || TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
        {
            player1Animator = GameObject.FindGameObjectWithTag("Player1Animator").GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetButtonDown("Attack"))
        {
            curAction = "attack";
            showAction.text = "Attack";

            if (NextButtonCharacterSelection.player1UseAnimation || TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
            {
                player1Animator.SetBool("Punch", true);
                player1Animator.SetBool("Block", false);
                player1Animator.speed = 0.65f;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetButtonDown("Defend"))
        {
            if (NextButtonCharacterSelection.player1UseAnimation || TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
            {
                player1Animator.SetBool("Punch", false);
                player1Animator.SetBool("Block", true);
                player1Animator.speed = 1f;
            }

            curAction = "defend";
            showAction.text = "Defend";
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetButtonDown("Bluff"))
        {
            if (NextButtonCharacterSelection.player1UseAnimation || TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
            {
                player1Animator.SetBool("Punch", false);
                player1Animator.SetBool("Block", false);
                player1Animator.speed = 1f;
            }

            curAction = "bluff";
            showAction.text = "Bluff";
        }
        else if (Player2Data.curAction == "Death" && Player2Data.isDead)
        {
            if (NextButtonCharacterSelection.player1UseAnimation || TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
            {
                player1Animator.SetBool("Punch", false);
                player1Animator.SetBool("Block", false);
                player1Animator.speed = 1f;
            }

            curAction = "nothing";
            showAction.text = "Winner!";
        }
        else
        {
            curAction = "nothing";
            
            if (NextButtonCharacterSelection.player1UseAnimation || TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
            {
                player1Animator.SetBool("Punch",false);

                if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1PunchAnimation"))
                {
                    player1Animator.speed = 1f;
                }

                player1Animator.SetBool("Block", false);

                if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BlockAnimation"))
                {
                    player1Animator.speed = 1f;
                }

                //if (!player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1PunchAnimation"))
                //{
                //    player1Animator.speed = 1;
                //}   

                //if (!player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1PunchAnimation") && !player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BlockAnimation"))
                //{
                //    player1Animator.SetBool("Punch", false);
                //    player1Animator.SetBool("Block", false);
                //    player1Animator.speed = 1;
                //}

                //player1Animator.SetBool("Punch", false);
                //player1Animator.SetBool("Block", false);
                //player1Animator.speed = 1;
            }
        }  
    }

    public void TakeDamage(int amount)
    {
        curHealth -= amount;

        healthSlider.value = curHealth;

        if (curHealth <= 0 && !isDead)
        {
            Death();
        }
    }

    public void Death()
    {
        isDead = true;
        curAction = "Death";

        GameOver.isOver = true;
    }
}
