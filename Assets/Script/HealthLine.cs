using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthLine : MonoBehaviour
{
    private Vector3 startPos;
    private Vector3 endPos;

    private Image castImage;

    private RectTransform castTransform;

    private HealthBar healthBar = new HealthBar(2f, Color.green);
    private HealthBar healthBar2 = new HealthBar(1.5f, Color.red);
    private HealthBar healthBar3 = new HealthBar(1f, Color.blue);

    // Use this for initialization
    void Start()
    {
        castTransform = GetComponent<RectTransform>();
        castImage = GetComponent<Image>();
        endPos = castTransform.position;
        startPos = new Vector3(castTransform.position.x - castTransform.rect.width,castTransform.position.y, castTransform.position.z);
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
        castImage.color = healthBar.HealthColor;

        castTransform.position = startPos;

        float timeLeft = Time.deltaTime;

        float rate = 1.0f / healthBar.Health;

        float progress = 0.0f;

        while (progress <= 1.0)
        {
            castTransform.position = Vector3.Lerp(startPos, endPos, progress);

            progress += rate * Time.deltaTime;

            timeLeft += Time.deltaTime;

            yield return null;
        }

        castTransform.position = endPos;
    }
}
