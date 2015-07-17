using UnityEngine;
using System.Collections;

public class Fighting : MonoBehaviour
{

    public Player1Data player1;
    public Player2Data player2;
    
    public static int curAction1;
    public static int curAction2;
    public float stun1;
    public float stun2;
    public bool p2random;
    //private WaitForSeconds[] WaitSec = {new WaitForSeconds(1),new WaitForSeconds(2),new WaitForSeconds(3)};
    private float timer;
    bool countT = true;
    float waitTime = 0.5f;
    

    void Awake()
    {
    
        p2random = true;
        curAction1 = 0;
        curAction2 = 0;
        
        stun1 = 0;
        stun2 = 0;

    }
    
    // Update is called once per frame
    public void p2human()
    {
        p2random = false;
    }
    void Update()

    {
        
            

        //if (waitTime > 0)
        //{
        //    waitTime -= Time.deltaTime;

        //}
        //else
        //    {
        //    waitTime = 0.5f;
            result();
            player1.healthSlider.value = player1.curHealth;
            player2.healthSlider.value = player2.curHealth;

            if (player1.curHealth <= 0)
            {
                player1.SetDead();

                player1.action(0);
            }
            if (player2.curHealth <= 0)
            {
                player2.SetDead();
                player2.action(0);
            }






            curAction1 = 0;
            curAction2 = 0;
            //player2.action(curAction2);
            //player1.action(curAction1);
            if (Input.GetKeyDown(KeyCode.A) || Input.GetButtonDown("Attack") || Input.GetKeyDown(KeyCode.S) || Input.GetButtonDown("Defend") || Input.GetKeyDown(KeyCode.D) || Input.GetButtonDown("Bluff"))
            {
                controller1();
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                controller2();
            }
            if (p2random)
            {
                if (countT)
                {
                    rantimer();
                    countT = false;
                }
                if (timer > 0)
                {
                    timer -= Time.deltaTime;

                }
                else
                {
                    countT = true;
                    controller2();

                }
            }
        }
    //}
       
    

    public void controller1()
    {
        if (stun1 > 0)
        {
            curAction1 = 0;
            player1.action(curAction1);
            
            if (timer > 0)
            {
                stun1 -= Time.deltaTime;

            }
           
        }
        else
        {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetButtonDown("Attack"))
        {
            curAction1 = 1;
            player1.action(curAction1);
            Debug.Log("1");

          
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetButtonDown("Defend"))
        {
            curAction1 = 2;
            player1.action(curAction1);

            
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetButtonDown("Bluff"))
        {
            curAction1 = 3;
            player1.action(curAction1);
        }
        else if (Player1Data.curAction == "Death" )
        {
            curAction1 =0;
            player1.action(curAction1);
        }
        else
        {
            

                curAction1 = 0;
                player1.action(curAction1);
                
            }
            
        }
    }
        //result();
    
    public void controller2()
    {
        if (stun2 > 0)
        {
            curAction2 = 0;
            player2.action(curAction2);
            if (timer > 0)
            {
                stun2 -= Time.deltaTime;

            }
            }
            else
            {
                if (!p2random)
                {

                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        curAction2 = 1;
                        player2.action(curAction2);
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        curAction2 = 2;
                        player2.action(curAction2);
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        curAction2 = 3;
                        player2.action(curAction2);
                    }
                    else if (Player2Data.curAction == "Death")
                    {
                        curAction2 = 0;
                        player2.action(curAction2);
                    }
                    else
                    {



                        curAction2 = 0;
                        player2.action(curAction2);



                    }
                }
                else if (p2random)//rand
                {
                    float randValue = Random.value;
                    //int x = 0;
                    //if (randValue <= .50f) { x = 1; }
                    //else { x = 0; }
                    //StartCoroutine(wait(x));
                    randValue = Random.value;
                    if (randValue <= .20f) { curAction2 = 1; player2.action(curAction2); }

                    else if (randValue <= .40f) { curAction2 = 2; player2.action(curAction2); }

                    else if (randValue <= .60f) { curAction2 = 3; player2.action(curAction2); }

                    else
                    {
                        curAction2 = 0;
                        player2.action(curAction2);
                    }


                    if (Player2Data.curAction == "Death")
                    {
                        curAction2 = 0;
                        player2.action(curAction2);
                    }
                    else
                    {
                        player2.action(curAction2);


                    }
                }
            }
       // player2.action(curAction2);
        }
        //result();
        
    

    public void result()
    {
        
        if (curAction1 == 1 && curAction2 == 1)
        {
            player1.curHealth -= 5;
            player2.curHealth -= 5;

            player1.action(4); 
            player2.action(4);
        }
        else if (curAction1 ==1 && curAction2 == 2)
        {
            stun2 = 3;

        }
        else if (curAction1 == 2 && curAction2 == 1)
        {
            stun1 = 3;

        }
        else if (curAction1 == 1 && curAction2 == 3)
        {

            player2.curHealth -= 10;

           
            player2.action(4);
            
        }
        else if (curAction1 == 3 && curAction2 == 1)
        {
            player1.curHealth -= 10;

            player1.action(4);
            
           

        }
        else if (curAction1 == 3 && curAction2 == 3)
        {
            player1.curHealth -= 10;
            player2.curHealth -= 10;
            player1.action(5);
            player2.action(5);
            
        }
        else if (curAction1 == 2 && curAction2 == 3)
        {
            player1.curHealth -= 10;
            player1.action(5);
            
           
        }
        else if (curAction1 == 3 && curAction2 == 2)
        {

            player2.curHealth -= 10;
           
            player2.action(5);
           
        }
        else if (curAction1 == 3 && curAction2 == 0)
        {

            player2.curHealth -= 10;
            
            player2.action(5);
           
        }
        else if (curAction1 == 0 && curAction2 == 3)
        {

            player1.curHealth -= 10;
            player1.action(5);
           
            
        }
        else if (curAction1 == 1 && curAction2 == 0)
        {

            player2.curHealth -= 10;
           
            player2.action(4);
           
        }
        else if (curAction1 == 0 && curAction2 == 1)
        {

            player1.curHealth -= 10;
           
            player2.action(4);
            
        }
        
    }
void rantimer()
    {
        if (timer >= 0)
        {
            float randValue = Random.value;
            timer = randValue * 2;
        }
if (timer <= 0){timer=0;}
    }
        
    
    //IEnumerator wait(int x)
    //{
    //    yield return WaitSec[x];

    //}
    
}

