using System.Collections.Generic;
using UnityEngine;

public class ExecuteTsp : MonoBehaviour
{
    private EnemyGenerator enemyGenerator;
    private List<Vector3> enemies;
    private List<int> path;
    private int[,] distances;
    private Vector3 startPoint;

    private void Awake()
    {
        enemyGenerator = GetComponent<EnemyGenerator>();
    }

    private void Start()
    {
        enemies = enemyGenerator.GetEnemies();
        startPoint = enemyGenerator.GetStartPoint();
        
        if (!enemies.Contains(startPoint)) enemies.Add(startPoint);

        distances = CalculateDistances();
        path = TspSolver.NearestNeighbor(distances, enemies.IndexOf(startPoint));

        path = AddStartAndEndPoints(path);
        DrawPath();
        PrintTotalDistance(distances);
    }
    
    private int[,] CalculateDistances()
    {
        int n = enemies.Count;
        int[,] distances = new int[n, n];
        
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                int distance = (int) Vector3.Distance(enemies[i], enemies[j]);
                distances[i, j] = distance;
                distances[j, i] = distance;
            }
        }
        return distances;
    }

    private List<int> AddStartAndEndPoints(List<int> path)
    {
        List<int> newPath = new List<int>();
        newPath.AddRange(path);
        newPath.Add(enemies.IndexOf(startPoint));
        return newPath;
    }
    
    private void PrintTotalDistance(int[,] distances)
    {
        int totalDistance = 0;
        
        totalDistance += distances[path[^1], enemies.IndexOf(startPoint)];
        
        for (int i = 0; i < path.Count - 1; i++)
        {
            totalDistance += distances[path[i], path[i + 1]];
        }
        
        totalDistance += distances[enemies.IndexOf(startPoint), path[0]];
        Debug.Log("The total distance is " + totalDistance.ToString());
    }
    
    private void DrawPath()
    {
        for (int i = 0; i < path.Count - 1; i++)
        {
            Vector3 start = enemies[path[i]];
            Vector3 end = enemies[path[i+1]];
            Debug.DrawLine(start, end, Color.red, Mathf.Infinity);
        }
    }
    
    public List<Vector3> GetPath()
    {
        if (path == null)
        {
            Debug.LogWarning("Path variable is null.");
            return null;
        }
        List<Vector3> pathPoints = new List<Vector3>();
        foreach (int index in path)
        {
            pathPoints.Add(enemies[index]);
        }
        return pathPoints;
    }

}
