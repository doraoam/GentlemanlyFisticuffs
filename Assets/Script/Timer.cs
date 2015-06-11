using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timerText;

    public static float timer;

    // Use this for initialization
    void Start()
    {
        Timer.timer = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timerText.text = timer.ToString("F0");     
        }
        else
        {
            GameOver.isOver = true;

            //timer = 0;
            //timerText.color = Color.red;
            //timerText.color = new Color(0.0f, 0.0f, 1.0f, 0.0f);
            //timerText.text = "Game Over";
        }
    }
}
