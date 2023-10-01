using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    public GameObject barrier; 
    public Sprite pressedLeverSprite; 
    private SpriteRenderer leverSpriteRenderer; 
    private bool isLeverActivated = false;

    void Start()
    {
        leverSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isLeverActivated)
        {
            barrier.SetActive(false);

            // Change the lever's sprite to the pressed sprite
            if (pressedLeverSprite != null)
            {
                leverSpriteRenderer.sprite = pressedLeverSprite;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Press SPACE to activate the lever");

            isLeverActivated = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isLeverActivated = false;
        }
    }
}
