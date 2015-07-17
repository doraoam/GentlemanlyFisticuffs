using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player1Data : MonoBehaviour
{
    public Text player1Name;
    public Text showAction;
    
    public Animator player1Animator;

   
    public  int curHealth=400;

    public Slider healthSlider;

    public static string curAction;

    public Fighting fight;

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
        
        healthSlider.value = curHealth;
        

        if (player1Name.text == "Scottish")
        {
            player1Animator = GameObject.FindGameObjectWithTag("Player1Scottish").GetComponent<Animator>();
        }else if(player1Name.text == "English"){
            player1Animator = GameObject.FindGameObjectWithTag("Player1English").GetComponent<Animator>();
        }
        
    }
   // void Update()
  // {
      // WaitForAnimation(player1Animator.animation);
  //  }
    public  void SetDead(){

        curAction="Death";
        GameOver.isOver = true;
    }

   public void action(int x)
    {
        if (x==1)
        {
            

                player1Animator.SetBool("Punch", true);
                player1Animator.SetBool("Block", false);
                player1Animator.SetBool("Bluff", false);
                player1Animator.SetBool("Punched", false);
                player1Animator.SetBool("Bluffed", false);
                player1Animator.speed = 1f;
                Debug.Log("hit");
           
        }
        else if (x==2)
        {
           


                player1Animator.SetBool("Punch", false);
                player1Animator.SetBool("Block", true);
                player1Animator.SetBool("Bluff", false);
                player1Animator.SetBool("Punched", false);
                player1Animator.SetBool("Bluffed", false);
                player1Animator.speed = 1f;
            
        }
        else if (x==3)
        {
            


           
                player1Animator.SetBool("Punch", false);
                player1Animator.SetBool("Block", false);
                player1Animator.SetBool("Bluff", true);
                player1Animator.SetBool("Punched", false);
                player1Animator.SetBool("Bluffed", false);
            
                player1Animator.speed = 1f;
            
        }
               else if (x == 4)
        {
            player1Animator.SetBool("Punched", true);
            player1Animator.SetBool("Block", false);
            player1Animator.SetBool("Bluff", false);
            player1Animator.SetBool("Punch", false);
            player1Animator.SetBool("Bluffed", false);
            }
        else if (x == 5)
        {
            player1Animator.SetBool("Block", false);
            player1Animator.SetBool("Punch", false);
            player1Animator.SetBool("Bluff", false);
            player1Animator.SetBool("Punched", false);
            player1Animator.SetBool("Bluffed", true);
        }
        else if (Player1Data.curAction == "Death")
        {
            SetDead();


            
                player1Animator.SetBool("Punch", false);
                player1Animator.SetBool("Block", false);
                player1Animator.SetBool("Bluff", false);
                player1Animator.SetBool("Punched", false);
                player1Animator.SetBool("Bluffed", false);
                player1Animator.speed = 1f;
            
        }
        else
        {
            

            
                 player1Animator.SetBool("Punch", false);
                player1Animator.SetBool("Block", false);
                player1Animator.SetBool("Bluff", false);
                player1Animator.SetBool("Punched", false);
                player1Animator.SetBool("Bluffed", false);
                
            }
        
        }


   //private IEnumerator WaitForAnimation(Animation animation)
   //{
   //    do
   //    {
   //        yield return null;
   //    } while (animation.isPlaying);
   //}
    }


    