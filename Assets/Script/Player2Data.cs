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

    public GameObject punch;
    public GameObject bluff;

    // Use this for initialization
    public void Awake()
    {
        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer)
        {
            player2Name.text = TwoPlayerNextButtonCharacterSelection.player2Name;
        }
        else
        {
            player2Name = GameObject.FindGameObjectWithTag("Player2Name").GetComponent<Text>();
        }

        curAction = "nothing";
        showAction.text = "Nothing";
        curHealth = maxHealth;
        healthSlider.value = curHealth;
        isDead = false;

        if (player2Name.text == "Scottish")
        {
            player2Animator = GameObject.FindGameObjectWithTag("Player2Scottish").GetComponent<Animator>();
        }
        else if (player2Name.text == "English")
        {
            player2Animator = GameObject.FindGameObjectWithTag("Player2English").GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (TwoPlayerNextButtonCharacterSelection.isTwoPlayer != true)
        {
            if(NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation){
                if (!player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2PunchDamageAnimation") && !player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2BluffDamageAnimation"))
                {
                    AutoController();
                }
                else
                {
                    if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2BluffDamageAnimation"))
                    {
                        player2Animator.SetBool("Punch", false);
                        player2Animator.SetBool("Block", false);
                        player2Animator.SetBool("Bluff", false);
                        player2Animator.SetBool("Bluffed", false);
                    }

                    if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2PunchDamageAnimation"))
                    {
                        player2Animator.SetBool("Punch", false);
                        player2Animator.SetBool("Block", false);
                        player2Animator.SetBool("Bluff", false);
                        player2Animator.SetBool("Punched", false);
                    }
                }
            }else{
                AutoController();
            }
        }
        else
        {
            if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
            {
                if (!player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2PunchDamageAnimation") && !player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2BluffDamageAnimation"))
                {
                    controller();
                }
                else
                {
                    if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2BluffDamageAnimation"))
                    {
                        player2Animator.SetBool("Punch", false);
                        player2Animator.SetBool("Block", false);
                        player2Animator.SetBool("Bluff", false);
                        player2Animator.SetBool("Bluffed", false);
                    }

                    if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2PunchDamageAnimation"))
                    {
                        player2Animator.SetBool("Punch", false);
                        player2Animator.SetBool("Block", false);
                        player2Animator.SetBool("Bluff", false);
                        player2Animator.SetBool("Punched", false);
                    }
                }
            }
            else
            {
                controller();
            }
        }
    }

    void AutoController()
    {
        if (Player1Data.curAction != "Death" && (Player1Data.curAction != "Punched" || Player1Data.curAction != "Bluffed") && Player1Data.curAction != "nothing") 
        {
            float randValue = Random.value;
            if (randValue < .33f)
            {
                curAction = "attack";
                showAction.text = "Attack";
                GameObject punchHit = (GameObject)Instantiate(punch, new Vector3(215, 200, 0), Quaternion.identity);
                Destroy(punchHit, 1);
                if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
                {
                    player2Animator.SetBool("Punch", true);
                    player2Animator.SetBool("Block", false);
                    player2Animator.SetBool("Bluff", false);
                    player2Animator.speed = 1f;
                }
            }
            else if (randValue >= .33f && randValue < .66f)
            {
                curAction = "defend";
                showAction.text = "Defend";

                if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
                {
                    player2Animator.SetBool("Punch", false);
                    player2Animator.SetBool("Block", true);
                    player2Animator.SetBool("Bluff", false);
                    player2Animator.speed = 1f;
                }
            }
            else if (randValue > .66f)
            {
                curAction = "bluff";
                showAction.text = "Bluff";
                GameObject bluffHit = (GameObject)Instantiate(bluff, new Vector3(215, 200, 0), Quaternion.identity);
                Destroy(bluffHit, 1);
                if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
                {
                    player2Animator.SetBool("Punch", false);
                    player2Animator.SetBool("Block", false);
                    player2Animator.SetBool("Bluff", true);
                    player2Animator.speed = 1f;
                }
            }
            else
            {
                if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
                {
                    player2Animator.SetBool("Punch", false);
                    player2Animator.SetBool("Block", false);
                    player2Animator.SetBool("Bluff", false);
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
                player2Animator.SetBool("Bluff", false);
                player2Animator.speed = 1f;
            }

            curAction = "nothing";
            showAction.text = "Winner!";
        }
        else
        {
            if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
            {
                if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2PunchAnimation"))
                {
                    player2Animator.SetBool("Punch", false);
                }

                if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2BlockAnimation"))
                {
                    player2Animator.SetBool("Block", false);
                }

                if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2BluffAnimation"))
                {
                    player2Animator.SetBool("Bluff", false);
                }
            }
        }
    }

    void controller()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            curAction = "attack";
            showAction.text = "Attack";
            GameObject punchHit = (GameObject)Instantiate(punch, new Vector3(215, 200, 0), Quaternion.identity);
            Destroy(punchHit, 1);
            if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
            {
                player2Animator.SetBool("Punch", true);
                player2Animator.SetBool("Block", false);
                player2Animator.SetBool("Bluff", false);
                player2Animator.speed = 1f;
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            curAction = "defend";
            showAction.text = "Defend";

            if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
            {
                player2Animator.SetBool("Punch", false);
                player2Animator.SetBool("Block", true);
                player2Animator.SetBool("Bluff", false);
                player2Animator.speed = 1f;
            }

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            curAction = "bluff";
            showAction.text = "Bluff";
            GameObject bluffHit = (GameObject)Instantiate(bluff, new Vector3(215, 200, 0), Quaternion.identity);
            Destroy(bluffHit, 1);
            if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
            {
                player2Animator.SetBool("Punch", false);
                player2Animator.SetBool("Block", false);
                player2Animator.SetBool("Bluff", true);
                player2Animator.speed = 1f;
            }
        }
        else if (Player1Data.curAction == "Death" && Player1Data.isDead)
        {
            curAction = "nothing";
            showAction.text = "Winner!";

            if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
            {
                player2Animator.SetBool("Punch", false);
                player2Animator.SetBool("Block", false);
                player2Animator.SetBool("Bluff", false);
                player2Animator.speed = 1f;
            }
        }
        else
        {
            curAction = "nothing";

            if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
            {
                if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2PunchAnimation"))
                {
                    player2Animator.SetBool("Punch", false);
                }

                if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2BlockAnimation"))
                {
                    player2Animator.SetBool("Block", false);
                }

                if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player2BluffAnimation"))
                {
                    player2Animator.SetBool("Bluff", false);
                }
            }
        }
    }

    public void TakeDamage(int amount,string action)
    {
        if (NextButtonCharacterSelection.player2UseAnimation || TwoPlayerNextButtonCharacterSelection.player2UseAnimation)
        {
            if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1PunchAnimation"))
            {
                player2Animator.SetBool("Punch", false);
                getDamage(action);
            }
            else if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BlockAnimation"))
            {
                player2Animator.SetBool("Block", false);
                getDamage(action);
            }
            else if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Player1BluffAnimation"))
            {
                player2Animator.SetBool("Bluff", false);
                getDamage(action);
            }
            else
            {
                getDamage(action);
            }
        }
        else
        {
            if (action == "attack" && curAction != "defend")
            {
                curAction = "Punched";
            }
            else if (action == "bluff" && curAction != "attack")
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

    public void getDamage(string action)
    {
        if (action == "attack" && curAction != "defend")
        {
            player2Animator.SetBool("Punched", true);

            curAction = "Punched";
        }
        else if (action == "bluff" && curAction != "attack")
        {
            player2Animator.SetBool("Bluffed", true);

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
