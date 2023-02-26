using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollowup : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int curWaypointIdx = 0;

    [SerializeField] private float speed = 2f;
    // Update is called once per frame
    private void Update()
    {
        if(Vector2.Distance(waypoints[curWaypointIdx].transform.position, transform.position)<.1f)
        {
            curWaypointIdx = (curWaypointIdx + 1) % 2;
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[curWaypointIdx].transform.position, Time.deltaTime * speed);
    }
}
