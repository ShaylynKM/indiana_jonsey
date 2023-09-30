using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door; 
    public GameObject key;
    private bool hasKey = false; 
    private bool playerInsideCollider = false; 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInsideCollider = true;
            if (hasKey)
            {
                Debug.Log("Press SPACE to open the door.");
            }
            else
            {
                Debug.Log("You need a key to open this door!");
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInsideCollider = false;
        }
    }

    void Update()
    {
        // Check if the player is inside the door's collider and presses the space bar
        if (playerInsideCollider && hasKey && Input.GetKeyDown(KeyCode.Space))
        {
            door.SetActive(false);
            Debug.Log("Door opened!");
        }
    }

    public void CollectKey()
    {
        // Set the hasKey flag to true when the player collects the key
        hasKey = true;
        key.SetActive(false);
        Debug.Log("Key collected!");
    }
}

