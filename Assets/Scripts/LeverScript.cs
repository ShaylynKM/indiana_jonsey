using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverScript : MonoBehaviour
{
    public Sprite NeutralSprite;
    public Sprite pressedLeverSprite; 
    private SpriteRenderer leverSpriteRenderer; 
    private bool isLeverActivated = false;
    public UnityEvent leverEvent;
    private bool isPressed = false;
    void Start()
    {
        leverSpriteRenderer = GetComponent<SpriteRenderer>();
        NeutralSprite = leverSpriteRenderer.sprite;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isLeverActivated)
        {
            leverEvent.Invoke();
            // barrier.SetActive(false);
            isPressed = !isPressed;
            // Change the lever's sprite to the pressed sprite
            if ((pressedLeverSprite != null) && (isPressed == false))
            {
                leverSpriteRenderer.sprite = pressedLeverSprite;
            }
            else
            {
                leverSpriteRenderer.sprite = NeutralSprite;
            }
            AudioManager.Instance.PlayDoor();
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
