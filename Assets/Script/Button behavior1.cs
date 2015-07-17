using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Buttonbehavior1 : MonoBehaviour {

    public Sprite sprite1; // Drag your first sprite here
    public Sprite sprite2; // Drag your second sprite here

    private SpriteRenderer spriteRenderer;

    void Start()
    {
       
        spriteRenderer = GetComponent<SpriteRenderer>();

    }
    void Update()
    {
    }
   
    void OnMouseDown()
    {
        spriteRenderer.sprite = sprite2;
    }
}
