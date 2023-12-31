using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    #region Events

    // All of these must have an associated function. May place them in other scripts if it makes more sense
    public UnityEvent WalkEvent;
    public UnityEvent VictoryEvent;
    public UnityEvent KeyPickupEvent;
    public UnityEvent DoorEvent;
    public UnityEvent PullLeverEvent;

    #endregion

    public int speed = 20;
    //private Levers levers;

    private Vector2 targetPosition; //was vector2Int

    private void Awake()
    {
        // set the initial target position to the rounded position of the player's transform
        targetPosition = new Vector2Int(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y));

        // snap the player's transform to the initial target position
        transform.position = (Vector2)targetPosition;
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
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        targetPosition = new Vector2(transform.position.x,transform.position.y); //fixes collision issues but does something to movement
    }

    private void SetNewTargetPositionFromInput()
    {
        Vector2Int movementDirection = Vector2Int.zero;

        if (Input.GetKey(KeyCode.W))
        {
            targetPosition += Vector2Int.up;
            if (targetPosition.x != transform.position.x)
            {
                targetPosition.x = transform.position.x;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            targetPosition += Vector2Int.left;
            if (targetPosition.y != transform.position.y)
            {
                targetPosition.y = transform.position.y;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            targetPosition += Vector2Int.down;
            if (targetPosition.x != transform.position.x)
            {
                targetPosition.x = transform.position.x;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            targetPosition += Vector2Int.right;
            if(targetPosition.y != transform.position.y)
            {
                targetPosition.y = transform.position.y;
            }
        }
    }

    //public bool OnInteract()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("Lever"))
    //    {
    //        Debug.Log("trigger");
    //        if (Input.GetKey(KeyCode.Space))
    //        {
    //            ClickLever();
    //        }
    //    }
    //}

    //private void ClickLever()
    //{
    //    levers.OnLeverClicked();
    //}
}

