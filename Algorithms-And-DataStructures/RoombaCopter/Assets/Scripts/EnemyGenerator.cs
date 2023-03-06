using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public delegate void EnemiesMovedEventHandler(List<Vector3> newPositions);

    public int numEnemies = 10; 
    public float minX = -10f, maxX = 10f;
    public float minZ = -10f, maxZ = 10f;
    public float fixedY = 2f; 
    public float enemyRadius = 1f; 
    public Vector3 pointOfOrigin;
    public GameObject enemiesPrefab;
    public GameObject originPrefab;

    private List<Vector3> enemies;

    private void Awake()
    {
        GenerateEnemies();
    }

    private void GenerateEnemies()
    {
        enemies = new List<Vector3>();
        
        GameObject startPointObject = Instantiate(originPrefab, pointOfOrigin, Quaternion.identity);
        startPointObject.transform.localScale = (enemiesPrefab.transform.localScale * enemyRadius) * 0.25f;

        // Generate enemies
        for (int i = 0; i < numEnemies; i++)
        {
            bool enemiesOverlap = true;
            Vector3 enemy = Vector3.zero;

            while (enemiesOverlap)
            {
                float x = Random.Range(minX, maxX);
                float z = Random.Range(minZ, maxZ);
                enemy = new Vector3(x, fixedY, z);
                
                Collider[] hitColliders = new Collider[10];
                int numColliders = Physics.OverlapSphereNonAlloc(enemy, enemyRadius, hitColliders);
                
                bool collidesWithObstacle = false;
                for (int j = 0; j < numColliders; j++)
                {
                    Obstacle obstacle = hitColliders[j].gameObject.GetComponent<Obstacle>();
                    if (obstacle != null)
                    {
                        collidesWithObstacle = true;
                        break;
                    }
                }
                
                if (!collidesWithObstacle)
                {
                    foreach (Vector3 otherEnemies in enemies)
                    {
                        if (!(Vector3.Distance(enemy, otherEnemies) < 2 * enemyRadius)) continue;
                        collidesWithObstacle = true;
                        break;
                    }
                    if (Vector3.Distance(enemy, pointOfOrigin) < 2 * enemyRadius) break;
                }
                enemiesOverlap = collidesWithObstacle;
            }
            enemies.Add(enemy);
            GameObject enemyObject = Instantiate(enemiesPrefab, enemy, Quaternion.identity);
            enemyObject.transform.localScale = enemiesPrefab.transform.localScale * enemyRadius;
        }
    }

    public List<Vector3> GetEnemies()
    {
        return enemies;
    }

    public Vector3 GetStartPoint()
    {
        return pointOfOrigin;
    }
}