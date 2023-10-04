using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    public GameObject door; 
    public GameObject key;
    private bool hasKey = false; 
    private bool playerInsideCollider = false;
    [SerializeField] private string _nextScene;
    
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
            door.GetComponent<SpriteRenderer>().enabled = false;
            AudioManager.Instance.PlayVictory();
            StartCoroutine("Wait");
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

    IEnumerator Wait()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(1.420f);
        Time.timeScale = 1f;
        SceneManager.LoadScene(_nextScene);
    }
}

