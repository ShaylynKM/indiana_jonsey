using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    public DoorController doorController;
    private bool canCollect = false; 

    void Update()
    {
        // Check if the player is in the key's trigger zone and presses space to collect the key
        if (canCollect && Input.GetKeyDown(KeyCode.Space))
        {
            // Call the CollectKey function in the DoorController script
            doorController.CollectKey();
            AudioManager.Instance.PlayKeyPickup();
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Press SPACE to collect the key");
            canCollect = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Key collected");
            canCollect = false;
        }
    }
}
