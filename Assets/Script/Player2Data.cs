using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player2Data : MonoBehaviour
{
    public Text player2Name;
    public Text showAction;

    public float maxHealth = 100;
    public float curHealth;

    public Slider healthSlider;

    public static string curAction;

    public static bool isDead;

    // Use this for initialization
    void Start()
    {
        player2Name.text = "Enemy";

        showAction.text = "Nothing";

        curHealth = maxHealth;

        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1Data.curAction != "nothing" && Player1Data.curAction != "Death")
        {
            float randValue = Random.value;
            if (randValue < .45f)
            {
                curAction = "attack";
                showAction.text = "Attack";
            }
            else if (randValue >= .45f && randValue < .9f)
            {
                curAction = "defend";
                showAction.text = "Defend";
            }
            else
            {
                curAction = "bluff";
                showAction.text = "Bluff";
            }
        }
        else if (Player1Data.curAction == "Death" && Player1Data.isDead)
        {
            curAction = "nothing";
            showAction.text = "Winner!";
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
