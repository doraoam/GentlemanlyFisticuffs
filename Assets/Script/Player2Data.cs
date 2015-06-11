using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player2Data : MonoBehaviour
{
    public Text player2Name;

    public float maxHealth = 100;
    public float curHealth;

    public Slider healthSlider;

    public static string curAction;

    bool isDead;

    // Use this for initialization
    void Start()
    {
        player2Name.text = "Enemy";

        curHealth = maxHealth;

        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1Data.curAction != "nothing")
        {
            float randValue = Random.value;
            if (randValue < .45f)
            {
                curAction = "attack";
            }
            else if (randValue >= .45f && randValue < .9f)
            {
                curAction = "defend";
            }
            else
            {
                curAction = "bluff";
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
    }
}
