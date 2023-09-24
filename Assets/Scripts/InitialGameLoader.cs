using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitialGameLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoadGame();
    }
    IEnumerator LoadGame()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
