using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player1Data : MonoBehaviour
{

    public Text player1Name;

    public float maxHealth = 100;
    public float curHealth = 100;

    public Texture2D bgImage;
    public Texture2D fgImage;

    public float healthBarLength;

    // Use this for initialization
    void Start()
    {
        player1Name.text = "aaaaa";

        healthBarLength = Screen.width / 2;
    }

    // Update is called once per frame
    void Update()
    {
        AdjustCurrentHealth(0);
    }

    void OnGui()
    {
        GUI.BeginGroup(new Rect(0, 0, healthBarLength, 32));

        GUI.Box(new Rect(0, 0, healthBarLength, 32), bgImage);

        GUI.BeginGroup(new Rect(0, 0, curHealth / maxHealth * healthBarLength,32));

        GUI.Box(new Rect(0, 0, healthBarLength, 32), fgImage);

        GUI.EndGroup();

        GUI.EndGroup();
    }

    public void AdjustCurrentHealth(int adj)
    {
        curHealth += adj;

        if (curHealth < 0)
        {
            curHealth = 0;
        }

        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }

        if (maxHealth < 1)
        {
            maxHealth = 1;
        }

        healthBarLength = (Screen.width / 2) * (curHealth / (float)maxHealth);
    }
}
