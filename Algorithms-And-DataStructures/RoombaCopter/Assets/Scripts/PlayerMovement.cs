using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    
    private List<Vector3> path;
    private int currentPointIndex;

    private void Start()
    {
        ExecuteTsp executeTsp = FindObjectOfType<ExecuteTsp>();
        path = executeTsp.GetPath();
        currentPointIndex = 0;
        
        if (path != null) transform.position = path[currentPointIndex];
    }

    private void Update()
    {
        if (path == null) return;

        if (Vector3.Distance(new Vector3(transform.position.x, 0f, transform.position.z), new Vector3(path[currentPointIndex].x, 0f, path[currentPointIndex].z)) < 0.1f)
        {
            currentPointIndex++;
            if (currentPointIndex >= path.Count) currentPointIndex = 0;
        }
        
        Vector3 targetPosition = new Vector3(path[currentPointIndex].x, 2f, path[currentPointIndex].z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (path.Count > 1 && Vector3.Distance(new Vector3(transform.position.x, 0f, transform.position.z), new Vector3(targetPosition.x, 0f, targetPosition.z)) > 0.1f)
        {
            Vector3 direction = targetPosition - transform.position;
            direction.y = 0f;
            if (!(direction.magnitude > 0.1f)) return;
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * speed);
        }
    }
}