using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player1Data : MonoBehaviour
{
    public Text player1Name;
    public Text showAction;

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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            curAction = "attack";
            showAction.text = "Attack";
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            curAction = "defend";
            showAction.text = "Defend";
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            curAction = "bluff";
            showAction.text = "Bluff";
        }else if(Player2Data.curAction == "Death" && Player2Data.isDead){
            curAction = "nothing";
            showAction.text = "Winner!";
        }
        else
        {
            curAction = "nothing";
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
