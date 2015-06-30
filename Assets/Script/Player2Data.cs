using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player2Data : MonoBehaviour
{
    public Text player2Name;
    public Text showAction;

    public Animator player2Animator;

    public float maxHealth = 100;
    public float curHealth;

    public Slider healthSlider;

    public static string curAction;

    public static bool isDead;

    // Use this for initialization
    public void Awake()
    {
        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer)
        {
            player2Name.text = TwoPlayerNextButtonCharacterSelection.player2Name;
        }
        else
        {
            player2Name.text = "Enemy";
            curAction = "nothing";
        }
        
        showAction.text = "Nothing";

        curHealth = maxHealth;

        isDead = false;

        if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
        {
            player2Animator = GameObject.FindGameObjectWithTag("Player2Animator").GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer != true)
        {
            if (Player1Data.curAction != "nothing" && Player1Data.curAction != "Death")
            {
                float randValue = Random.value;
                if (randValue < .45f)
                {
                    curAction = "attack";
                    showAction.text = "Attack";

                    if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
                    {
                        player2Animator.SetBool("Punch", true);
                        player2Animator.SetBool("Block", false);
                        player2Animator.speed = 0.65f;
                    }
                }
                else if (randValue >= .45f && randValue < .9f)
                {
                    if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
                    {
                        player2Animator.SetBool("Punch", false);
                        player2Animator.SetBool("Block", true);
                        player2Animator.speed = 1f;
                    }

                    curAction = "defend";
                    showAction.text = "Defend";
                }
                else if(randValue > .9f)
                {
                    if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
                    {
                        player2Animator.SetBool("Punch", false);
                        player2Animator.SetBool("Block", false);
                        player2Animator.speed = 1f;
                    }

                    curAction = "bluff";
                    showAction.text = "Bluff";
                }
                else
                {
                    if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
                    {
                        player2Animator.SetBool("Punch", false);
                        player2Animator.SetBool("Block", false);
                        player2Animator.speed = 1f;
                    }
                }
            }
            else if (Player1Data.curAction == "Death" && Player1Data.isDead)
            {
                if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
                {
                    player2Animator.SetBool("Punch", false);
                    player2Animator.SetBool("Block", false);
                    player2Animator.speed = 1f;
                }

                curAction = "nothing";
                showAction.text = "Winner!";
            }
            else
            {
                if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
                {
                    player2Animator.SetBool("Punch", false);

                    if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1PunchAnimation"))
                    {
                        player2Animator.speed = 1f;
                    }

                    player2Animator.SetBool("Block", false);

                    if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BlockAnimation"))
                    {
                        player2Animator.speed = 1f;
                    }
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                curAction = "attack";
                showAction.text = "Attack";

                if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
                {
                    player2Animator.SetBool("Punch", true);
                    player2Animator.SetBool("Block", false);
                    player2Animator.speed = 0.65f;
                }
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
                {
                    player2Animator.SetBool("Punch", false);
                    player2Animator.SetBool("Block", true);
                    player2Animator.speed = 1f;
                }

                curAction = "defend";
                showAction.text = "Defend";
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
                {
                    player2Animator.SetBool("Punch", false);
                    player2Animator.SetBool("Block", false);
                    player2Animator.speed = 1f;
                }

                curAction = "bluff";
                showAction.text = "Bluff";
            }
            else if (Player1Data.curAction == "Death" && Player1Data.isDead)
            {
                if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
                {
                    player2Animator.SetBool("Punch", false);
                    player2Animator.SetBool("Block", false);
                    player2Animator.speed = 1f;
                }

                curAction = "nothing";
                showAction.text = "Winner!";
            }
            else
            {
                curAction = "nothing";

                if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
                {
                    player2Animator.SetBool("Punch", false);

                    if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1PunchAnimation"))
                    {
                        player2Animator.speed = 1f;
                    }

                    player2Animator.SetBool("Block", false);

                    if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BlockAnimation"))
                    {
                        player2Animator.speed = 1f;
                    }
                }
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
