using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthLine : MonoBehaviour
{
    private Vector3 startPos;
    private Vector3 endPos;

    private Image healthImage;

    private RectTransform healthTransform;

    private HealthBar healthBar = new HealthBar(2f, Color.green);

    // Use this for initialization
    void Start()
    {
        healthTransform = GetComponent<RectTransform>();
        healthImage = GetComponent<Image>();
        endPos = healthTransform.position;
        startPos = new Vector3(healthTransform.position.x - healthTransform.rect.width,healthTransform.position.y, healthTransform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(CastSpell(healthBar));
        }
    }

    private IEnumerator CastSpell(HealthBar healthBar)
    {
        healthImage.color = healthBar.HealthColor;
        healthTransform.position = startPos;
        float rate = 1.0f / healthBar.Health;

        float progress = 0.0f;

        while (progress <= 1.0)
        {
            healthTransform.position = Vector3.Lerp(endPos, startPos, progress);

            progress += rate * Time.deltaTime;
            yield return null;
        }

        healthTransform.position = endPos;
    }
}
