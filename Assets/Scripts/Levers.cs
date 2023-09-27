using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levers : MonoBehaviour
{
    public GameObject player;
    public GameObject door;

    private PlayerController_anna playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = player.GetComponent<PlayerController_anna>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("trigger");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("click");
                OnLeverClicked();
            }
        }
    }

    public void OnLeverClicked()
    {
        Debug.Log("open");
        door.SetActive(false);
    }
}
