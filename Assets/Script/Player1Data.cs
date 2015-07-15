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
        if (NextButtonCharacterSelection.playerName != null)
        {
            player1Name.text = NextButtonCharacterSelection.playerName;
        }else if(TwoPlayerNextButtonCharacterSelection.isTwoPlayer){
            player1Name.text = TwoPlayerNextButtonCharacterSelection.player1Name;
        }
        else
        {
            player1Name = GameObject.FindGameObjectWithTag("Player1Name").GetComponent<Text>();
        }

        curAction = "nothing";
        showAction.text = "Nothing";
        curHealth = maxHealth;
        healthSlider.value = curHealth;
        isDead = false;

        if (player1Name.text == "Scottish")
        {
            player1Animator = GameObject.FindGameObjectWithTag("Player1Scottish").GetComponent<Animator>();
        }else if(player1Name.text == "English"){
            player1Animator = GameObject.FindGameObjectWithTag("Player1English").GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (NextButtonCharacterSelection.player1UseAnimation || TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
        {
            if (!player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1PunchDamageAnimation") && !player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BluffDamageAnimation"))
            {
                controller();
            }
            else
            {
                if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BluffDamageAnimation"))
                {
                    player1Animator.SetBool("Bluffed", false);
                }

                if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1PunchDamageAnimation"))
                {
                    player1Animator.SetBool("Punched", false);
                }
            }
        }
        else
        {
            controller();
        }
    }

    void controller()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetButtonDown("Attack"))
        {
            curAction = "attack";
            showAction.text = "Attack";

            if (NextButtonCharacterSelection.player1UseAnimation || TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
            {
                player1Animator.SetBool("Punch", true);
                player1Animator.SetBool("Block", false);
                player1Animator.SetBool("Bluff", false);
                player1Animator.speed = 1f;
            }
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetButtonDown("Defend"))
        {
            curAction = "defend";
            showAction.text = "Defend";

            if (NextButtonCharacterSelection.player1UseAnimation || TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
            {
                player1Animator.SetBool("Punch", false);
                player1Animator.SetBool("Block", true);
                player1Animator.SetBool("Bluff", false);
                player1Animator.speed = 1f;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetButtonDown("Bluff"))
        {
            curAction = "bluff";
            showAction.text = "Bluff";

            if (NextButtonCharacterSelection.player1UseAnimation || TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
            {
                player1Animator.SetBool("Punch", false);
                player1Animator.SetBool("Block", false);
                player1Animator.SetBool("Bluff", true);
                player1Animator.speed = 1f;
            }
        }
        else if (Player2Data.curAction == "Death" && Player2Data.isDead)
        {
            curAction = "nothing";
            showAction.text = "Winner!";

            if (NextButtonCharacterSelection.player1UseAnimation || TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
            {
                player1Animator.SetBool("Punch", false);
                player1Animator.SetBool("Block", false);
                player1Animator.SetBool("Bluff", false);
                player1Animator.speed = 1f;
            }
        }
        else
        {
            curAction = "nothing";

            if (NextButtonCharacterSelection.player1UseAnimation || TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
            {
                if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1PunchAnimation"))
                {
                    player1Animator.SetBool("Punch", false);
                }

                if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BlockAnimation"))
                {
                    player1Animator.SetBool("Block", false);
                }

                if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BluffAnimation"))
                {
                    player1Animator.SetBool("Bluff", false);
                }
            }
        }
    }

    public void TakeDamage(int amount,string action)
    {
        if (NextButtonCharacterSelection.player1UseAnimation || TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
        {
            if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1PunchAnimation"))
            {
                player1Animator.SetBool("Punch", false);
                getDamge(action);
            }
            else if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BlockAnimation"))
            {
                player1Animator.SetBool("Block", false);
                getDamge(action);
            }
            else if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BluffAnimation"))
            {
                player1Animator.SetBool("Bluff", false);
                getDamge(action);
            }
            else
            {
                getDamge(action);
            }
        }
        else
        {
            if (action == "attack")
            {
                curAction = "Punched";
            }
            else if (action == "bluff")
            {
                curAction = "Bluffed";
            }

            if (curHealth <= 0 && !isDead)
            {
                Death();
            }
        }

        curHealth -= amount;

        healthSlider.value = curHealth;
    }

    public void getDamge(string action)
    {
        if (action == "attack")
        {
            player1Animator.SetBool("Punched", true);

            curAction = "Punched";
        }
        else if (action == "bluff")
        {
            player1Animator.SetBool("Bluffed", true);

            curAction = "Bluffed";
        }

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
