using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    public Transform playerTarget;

    public GameObject waypointPrefab;
    public List<Transform> waypoints = new List<Transform>();
    private Transform targetWaypoint;
    private int targetWaypointIndex = 0;
    private float minDistance = 0.1f;
    private int lastWaypointIndex;

    private float movementSpeed = 0.005f;
    private float rotationSpeed = 2.0f;

    
    void Start()
    {
        playerTarget = GameObject.Find("Player").transform;

        InitWaypoints();

        targetWaypoint = waypoints[targetWaypointIndex];
        lastWaypointIndex = waypoints.Count - 1;
    }

    public void InitWaypoints()
    {
        for(int i=0; i < 4; i++)
        {
            int x = Random.Range(-10, 10);
            int z = Random.Range(-10, 10);
            int y = 1;

            GameObject waypoint = Instantiate(waypointPrefab,new Vector3(x, y, z), Quaternion.identity);
            waypoints.Add(waypoint.transform);
        }

    }

    void Update()
    {
        float movementStep = movementSpeed * Time.deltaTime;

        Vector3 directionToTarget = targetWaypoint.position - transform.position;

        float distance = Vector3.Distance(transform.position, targetWaypoint.position);

        CheckDistanceToWaypoint(distance);

        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, movementSpeed);
        
        Vector3 newVector = playerTarget.position - gameObject.transform.position;
        //Debug.DrawRay(transform.position, newVector, Color.green);
        transform.rotation = Quaternion.LookRotation(newVector);
    }
    void CheckDistanceToWaypoint(float currentDistance)
    {
        if (currentDistance <= minDistance)
        {
            targetWaypointIndex++;
            UpdateTargetWaypoint();
        }
    }

    void UpdateTargetWaypoint()
    {
        if (targetWaypointIndex > lastWaypointIndex)
        {
            targetWaypointIndex = 0;
        }
        targetWaypoint = waypoints[targetWaypointIndex];
    }
   
}
