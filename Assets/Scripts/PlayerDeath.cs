using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events; // Important
using System.Collections;

public class PlayerDeath : MonoBehaviour
{
    public UnityEvent DieEvent;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("I am dead");
            Die();
        }
    }

    public void Die()
    {
        // DieEvent.Invoke(); // How to invoke the event
        Time.timeScale = 0f;
        StartCoroutine("Wait");

    }

    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(1.306f);
        Time.timeScale = 1f;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
