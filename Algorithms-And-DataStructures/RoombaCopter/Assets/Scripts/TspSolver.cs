using System.Collections.Generic;

public abstract class TspSolver
{
    public static List<int> NearestNeighbor(int[,] distances, int pointOfOriginIndex)
    {
        int n = distances.GetLength(0);
        var visited = new HashSet<int>();
        var path = new List<int>();
        
        visited.Add(pointOfOriginIndex);
        path.Add(pointOfOriginIndex);
        
        while (visited.Count < n)
        {
            int currentEnemy = path[^1];
            int nearestEnemy = -1;
            int nearestDistance = int.MaxValue;
            
            for (int i = 0; i < n; i++)
            {
                if (!visited.Contains(i) && distances[currentEnemy, i] < nearestDistance)
                {
                    nearestEnemy = i;
                    nearestDistance = distances[currentEnemy, i];
                }
            }
            visited.Add(nearestEnemy);
            path.Add(nearestEnemy);
        }
        return path;
    }
}