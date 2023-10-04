using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EnemyDamage : MonoBehaviour
{
    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Die();
            collision?.gameObject.GetComponent<PlayerDeath>().Die();
        }
    }
    private void Die()
    {
        AudioManager.Instance.PlayDie();
    }
}
    
