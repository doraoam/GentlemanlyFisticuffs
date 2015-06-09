using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour
{

    private float health;

    public float Health
    {
        get { return health; }
    }

    private Color32 healthColor;

    public Color32 HealthColor
    {
        get { return healthColor; }
    }

    public HealthBar(float health,Color32 healthColor)
    {
        this.health = health;
        this.healthColor = healthColor;
    }
}
