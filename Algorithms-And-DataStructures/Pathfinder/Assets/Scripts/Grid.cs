using System;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public struct Cell
{
    public bool walkable;
    public bool visited;
    //predecessor
    //costs
}
[CreateAssetMenu]
public class Grid : ScriptableObject
{
    public Cell[] cells; // 50
    public int width;  // 5
    public int Height => cells.Length / width;
    public Cell GetCell(int x, int y) => cells [x + y * width];

    public bool IsCellWalkable(int x, int y) => GetCell(x, y).walkable;
    public bool IsCellWalkable(Vector2Int pos) => IsCellWalkable(pos.x, pos.y);
}