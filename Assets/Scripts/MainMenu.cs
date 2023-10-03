using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Changes the scene to the first level after pressing the spacebar.
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Level-1");
        }
    }
}
