using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance { get; private set; }

    public GameObject Player;
    private Transform defaultPoint;
    private bool setPoint = false;
    private string spawnLocation = "DefaultSpawnLocation";
    private string setSpawnLocation = "";

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    public void SetSpawnLocation (string _location)
    {
        setSpawnLocation = _location;
        setPoint = true;
    }
    private void OnLevelWasLoaded(int level)
    {
        print(spawnLocation);
        if(level > 1)
        {
            Debug.Log("Spawn at location");
            Transform temp = GameObject.Find(setSpawnLocation).transform;
            Instantiate(Player, temp.position, Quaternion.identity);
            ResertLocation();
        }
        if(level == 1)
        {
            if(!setPoint)
            {
                Debug.Log("No point - spawn at default point");
                spawnAtStart();
            }
            else
            {
                spawnAtSetLocation();
            }
        }
    }
    void spawnAtSetLocation()
    {
        Debug.Log("Done spawning at set location");
        Transform spawnPoint = GameObject.Find(setSpawnLocation).transform;
        Instantiate(Player, spawnPoint.position, spawnPoint.rotation);
    }
    private void spawnAtStart()
    {
        defaultPoint = GameObject.Find("DefaultSpawnLocation").transform;
        Instantiate(Player, defaultPoint.position, defaultPoint.rotation);
    }
    private void ResertLocation()
    {
        spawnLocation = "DefaultSpawnLocation";
        setPoint = false;
    }
}
