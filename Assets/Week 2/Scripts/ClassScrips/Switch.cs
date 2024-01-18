using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//disables the whole game objects
//gameObject.SetActive(false);
//enables just the sprite not the whole game object
// spriteRenderer.enabled = false;

public class Switch : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.white;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger from: " + collision.gameObject);

        spriteRenderer.color = Color.red;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = Color.white;
            
    }
}
