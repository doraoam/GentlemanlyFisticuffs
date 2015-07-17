using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player2Data : MonoBehaviour
{
    public Text player2Name;
    public Text showAction;
    private float timer;

    public Animator player2Animator;

    public Fighting fight;
    public  int curHealth=400;

    public Slider healthSlider;

    public static string curAction;

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
     
        healthSlider.value = curHealth;
        

        if (player2Name.text == "Scottish")
        {
            player2Animator = GameObject.FindGameObjectWithTag("Player2Scottish").GetComponent<Animator>();
        }
        else if (player2Name.text == "English")
        {
            player2Animator = GameObject.FindGameObjectWithTag("Player2English").GetComponent<Animator>();
        }
       
    }
   // void Update()
  //  {
        //if (fight.p2random)
        //{
            
        //    rantimer();
        //    if (timer > 0)
        //    {
        //        timer -= Time.deltaTime;

        //    }
        //    else
        //    {

        //        fight.controller2();

        //    }
        //}
        //else
        //{
        //    fight.controller2();
        //}
    //}
    public  void SetDead()
    {

        curAction = "Death";
        GameOver.isOver = true;
    }
    public void action(int x)
    {
        if (x == 1)
        {


            player2Animator.SetBool("Punch", true);
            player2Animator.SetBool("Block", false);
            player2Animator.SetBool("Bluff", false);
            player2Animator.SetBool("Punched", false);
            player2Animator.SetBool("Bluffed", false);
            player2Animator.speed = 1f;

        }
        else if (x == 2)
        {



            player2Animator.SetBool("Punch", false);
            player2Animator.SetBool("Block", true);
            player2Animator.SetBool("Bluff", false);
            player2Animator.SetBool("Punched", false);
            player2Animator.SetBool("Bluffed", false);
            player2Animator.speed = 1f;

        }
        else if (x == 3)
        {




            player2Animator.SetBool("Punch", false);
            player2Animator.SetBool("Block", false);
            player2Animator.SetBool("Bluff", true);
            player2Animator.SetBool("Punched", false);
            player2Animator.SetBool("Bluffed", false);
            player2Animator.speed = 1f;

        }
            else if (x == 4)
        {
            player2Animator.SetBool("Punched", true);
            player2Animator.SetBool("Block", false);
            player2Animator.SetBool("Bluff", false);
            player2Animator.SetBool("Punch", false);
            player2Animator.SetBool("Bluffed", false);
            }
        else if (x == 5)
        {
            player2Animator.SetBool("Block", false);
            player2Animator.SetBool("Punch", false);
            player2Animator.SetBool("Bluff", false);
            player2Animator.SetBool("Punched", false);
            player2Animator.SetBool("Bluffed", true);
        }

        else if (Player1Data.curAction == "Death")
        {
            SetDead();



            player2Animator.SetBool("Punch", false);
            player2Animator.SetBool("Block", false);
            player2Animator.SetBool("Bluff", false);
            player2Animator.SetBool("Punched", false);
            player2Animator.SetBool("Bluffed", false);
            player2Animator.speed = 1f;

        }
        else
        {




            player2Animator.SetBool("Punch", false);
            player2Animator.SetBool("Block", false);
            player2Animator.SetBool("Bluff", false);
            player2Animator.SetBool("Punched", false);
            player2Animator.SetBool("Bluffed", false);
            player2Animator.speed = 1f;
        }



    }
    
    //void rantimer()
    //{
    //    if (timer <= 0)
    //    {
    //        float randValue = Random.value;
    //        timer = randValue * 3;
    //    }
    //}
    }
    


