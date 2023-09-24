using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private string spawnLocation;
    public string sceneName;
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");
        if (other.tag == "Player")
        {
            print("Switching Scene to " + spawnLocation);
            SpawnManager.Instance.SetSpawnLocation(spawnLocation);
            SceneManager.LoadScene(sceneName);
        }
    }
}