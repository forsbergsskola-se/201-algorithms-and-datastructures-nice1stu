using System.Collections.Generic;
using UnityEngine;
using System;

public class PathRequestManager : MonoBehaviour
{
    private readonly Queue<PathRequest> pathRequestQueue = new Queue<PathRequest>();
    private PathRequest currentPathRequest;
    private Pathfinding pathfinding;
    private static PathRequestManager _instance;
    private bool isProcessingPath;

    void Awake()
    {
        _instance = this;
        pathfinding = GetComponent<Pathfinding>();
    }
    
    public static void RequestPath(Vector3 pathStart, Vector3 pathEnd, Action<Vector3[], bool> callback)
    {
        PathRequest newRequest = new PathRequest(pathStart, pathEnd, callback);
        _instance.pathRequestQueue.Enqueue(newRequest);
        _instance.TryProcessNext();
    }

    void TryProcessNext()
    {
        if (isProcessingPath || pathRequestQueue.Count <= 0) return;
        currentPathRequest = pathRequestQueue.Dequeue();
        isProcessingPath = true;
        pathfinding.StartFindPath(currentPathRequest.pathStart, currentPathRequest.pathEnd);
    }

    public void FinishProcessingPath(Vector3[] path, bool success)
    {
        currentPathRequest.callback(path, success);
        isProcessingPath = false;
        TryProcessNext();
    }

    struct PathRequest
    {
        public readonly Vector3 pathStart;
        public readonly Vector3 pathEnd;
        public readonly Action<Vector3[], bool> callback;

        public PathRequest(Vector3 start, Vector3 end, Action<Vector3[], bool> callback)
        {
            pathStart = start;
            pathEnd = end;
            this.callback = callback;
        }
    }
}
