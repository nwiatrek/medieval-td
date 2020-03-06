using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followThePath : MonoBehaviour
{
    private Transform[] waypoints;

    private int moveSpeed;

    // Index of current waypoint from which Enemy walks
    // to the next one
    private int waypointIndex = 0;

    private KnightScript knight;

    // Use this for initialization
    private void Start()
    {
        knight = gameObject.GetComponentInParent(typeof(KnightScript)) as KnightScript;
        waypoints = FindObjectOfType<MapManager>().Waypoints;

        moveSpeed = knight.Speed;
        // Set position of Enemy as position of the first waypoint
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        // Move Enemy
        Move();
    }

    // Method that actually make Enemy walk
    private void Move()
    {
        // If Enemy didn't reach last waypoint it can move
        // If enemy reached last waypoint then it stops
        if (waypointIndex <= waypoints.Length - 1)
        {

            // Move Enemy from current waypoint to the next one
            // using MoveTowards method
            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);

            // If Enemy reaches position of waypoint he walked towards
            // then waypointIndex is increased by 1
            // and Enemy starts to walk to the next waypoint
            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                RotateIntoMoveDirection();
                waypointIndex += 1;
            }
        }
        if(waypointIndex == waypoints.Length)
        {
            knight.ReachedEnd();
        }
    }

    private void RotateIntoMoveDirection()
    {
        if(knight.transform.position == waypoints[waypoints.Length-1].transform.position)
        {
            Destroy(gameObject);
            return;
        }

        //1
        Vector3 newStartPosition = waypoints[waypointIndex].transform.position;
        Vector3 newEndPosition = waypoints[waypointIndex + 1].transform.position;
        Vector3 newDirection = (newEndPosition - newStartPosition);
        //2
        float x = newDirection.x;
        float y = newDirection.y;
        float rotationAngle = Mathf.Atan2(y, x) * 180 / Mathf.PI;
        //3
        knight.transform.rotation = Quaternion.AngleAxis(rotationAngle, Vector3.forward);
    }
}