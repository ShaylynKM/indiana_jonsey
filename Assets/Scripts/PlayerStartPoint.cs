using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour
{
    private PlayerController_test thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindAnyObjectByType<PlayerController_test>();
        thePlayer.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
