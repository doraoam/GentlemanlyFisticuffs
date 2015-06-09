using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CastingBar : MonoBehaviour
{
    private Vector3 startPos;
    private Vector3 endPos;

    private Image castImage;

    private RectTransform castTransform;

    private Spell fireBall = new Spell("Fire Ball", 2f, Color.red);
    private Spell frostBall = new Spell("Frost Bolt", 1.5f, Color.blue);
    private Spell heal = new Spell("Heal", 1f, Color.green);

    // Use this for initialization
    void Start()
    {
        castTransform = GetComponent<RectTransform>();
        castImage = GetComponent<Image>();
        endPos = castTransform.position;
        startPos = new Vector3(castTransform.position.x - castTransform.rect.width, castTransform.position.y, castTransform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(CastSpell(fireBall));
        }
    }

    private IEnumerator CastSpell(Spell spell)
    {
        castImage.color = spell.SpellColor;

        castTransform.position = startPos;

        float timeLeft = Time.deltaTime;

        float rate = 1.0f / spell.CastTime;

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
