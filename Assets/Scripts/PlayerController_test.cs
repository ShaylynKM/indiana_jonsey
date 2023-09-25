using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_test : MonoBehaviour
{
    public int speed = 20;

    private Vector2Int targetPosition;
    private static bool playerExists;
    private Rigidbody2D myRigidBody2D;

    private void Awake()
    {
        // set the initial target position to the rounded position of the player's transform
        targetPosition = new Vector2Int(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y));

        // snap the player's transform to the initial target position
        transform.position = (Vector2)targetPosition;
    }
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        if (!playerExists)
        {
            playerExists = true;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        // check if the player is currently moving (not at the target position)
        var moving = (Vector2)transform.position != targetPosition;

        if (moving)
        {
            MoveTowardsTargetPosition();
        }
        else
        {
            SetNewTargetPositionFromInput();
        }
    }

    private void MoveTowardsTargetPosition()
    {
        // use Vector2.MoveTowards to smoothly move the player
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    private void SetNewTargetPositionFromInput()
    {
        Vector2Int movementDirection = Vector2Int.zero;

        if (Input.GetKey(KeyCode.W))
        {
            targetPosition += Vector2Int.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            targetPosition += Vector2Int.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            targetPosition += Vector2Int.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            targetPosition += Vector2Int.right;
        }

    }
}

