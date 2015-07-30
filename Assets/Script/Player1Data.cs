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

    public GameObject punch;
    public GameObject defend;
    public GameObject bluff;

    bool isHurt;

    int lossPoint;

    Transform player2;

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
        else if (player1Name.text == "Irish")
        {
            player1Animator = GameObject.FindGameObjectWithTag("Player1Irish").GetComponent<Animator>();
        }

        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer)
        {
            if (TwoPlayerNextButtonCharacterSelection.player2Name == "Scottish")
            {
                player2 = GameObject.FindGameObjectWithTag("Player2Scottish").transform;
            }
            else if (TwoPlayerNextButtonCharacterSelection.player2Name == "English")
            {
                player2 = GameObject.FindGameObjectWithTag("Player2English").transform;
            }
            else if (TwoPlayerNextButtonCharacterSelection.player2Name == "Irish")
            {
                player2 = GameObject.FindGameObjectWithTag("Player2Irish").transform;
            }
        }
        else
        {
            if (NextButtonCharacterSelection.player2Name == "Scottish")
            {
                player2 = GameObject.FindGameObjectWithTag("Player2Scottish").transform;
            }
            else if (NextButtonCharacterSelection.player2Name == "English")
            {
                player2 = GameObject.FindGameObjectWithTag("Player2English").transform;
            }
            else if (NextButtonCharacterSelection.player2Name == "Irish")
            {
                player2 = GameObject.FindGameObjectWithTag("Player2Irish").transform;
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (NextButtonCharacterSelection.player1UseAnimation || TwoPlayerNextButtonCharacterSelection.player1UseAnimation)
        {
            if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1Animation"))
            {
                controller();
            }
            else
            {
                if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BluffDamageAnimation"))
                {
                    player1Animator.SetBool("Bluffed", false);

                    if (isHurt)
                    {
                        curHealth -= lossPoint;
                        healthSlider.value = curHealth;
                        isHurt = false;
                    }
                }

                if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1PunchDamageAnimation"))
                {
                    player1Animator.SetBool("Punched", false);

                    if (isHurt)
                    {
                        curHealth -= lossPoint;
                        healthSlider.value = curHealth;
                        isHurt = false;
                    }
                }

                player1Animator.SetBool("Punch", false);
                player1Animator.SetBool("Block", false);
                player1Animator.SetBool("Bluff", false);
            }

            //!player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1PunchDamageAnimation") && !player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BluffDamageAnimation")
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
            Vector3 destination = new Vector3(player2.position.x, player2.position.y, 0);
            GameObject punchHit = (GameObject)Instantiate(punch, destination, Quaternion.identity);
            Destroy(punchHit, 1);

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
            GameObject blockDefend = (GameObject)Instantiate(defend, player1Animator.transform.position, Quaternion.identity);
            Destroy(blockDefend, 1);
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
            Vector3 destination = new Vector3(player2.position.x, player2.position.y, 0);
            GameObject bluffHit = (GameObject)Instantiate(bluff, destination, Quaternion.identity);
            Destroy(bluffHit,1);
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
                getDamage(action);
            }
            else if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BlockAnimation"))
            {
                player1Animator.SetBool("Block", false);
                getDamage(action);
            }
            else if (player1Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BluffAnimation"))
            {
                player1Animator.SetBool("Bluff", false);
                getDamage(action);
            }
            else
            {
                getDamage(action);
            }
        }
        else
        {
            if (action == "attack" && curAction != "defend" && (curAction != "Punched" || curAction != "Bluffed") || action == "bluff" && curAction == "bluff")
            {
                curAction = "Punched";
            }
            else if (action == "bluff" && curAction != "attack" && (curAction != "Punched" || curAction != "Bluffed" || curAction == "bluff"))
            {
                curAction = "Bluffed";
            }

            if (curHealth <= 0 && !isDead)
            {
                Death();
            }
        }

        lossPoint = amount;

        isHurt = true;
    }

    public void getDamage(string action)
    {
        if (action == "attack" && curAction != "defend" && (curAction != "Punched" || curAction != "Bluffed") || action == "bluff" && curAction == "bluff")
        {
            player1Animator.SetBool("Punched", true);

            curAction = "Punched";
        }
        else if (action == "bluff" && curAction != "attack" && (curAction != "Punched" || curAction != "Bluffed" || curAction == "bluff"))
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
