using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events; // Important

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

    private void Die()
    {
        DieEvent.Invoke(); // How to invoke the event
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
