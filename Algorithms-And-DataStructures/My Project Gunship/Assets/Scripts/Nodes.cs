using UnityEngine;

public class Node : IHeapItem<Node>
{
    public readonly bool walkable;
    public Vector3 worldPosition;
    public readonly int gridX;
    public readonly int gridY;
    public int gCost;
    public int hCost;
    public Node parent;

    private int heapIndex;

    public Node(bool walkable, Vector3 worldPosition, int gridX, int gridY)
    {
        this.walkable = walkable;
        this.worldPosition = worldPosition;
        this.gridX = gridX;
        this.gridY = gridY;
    }

    private int FCost => gCost + hCost;

    public int HeapIndex { get; set; }

    public int CompareTo(Node node2Compare)
    {
        int compare = FCost.CompareTo(node2Compare.FCost);
        if (compare != 0) return -compare;
        compare = hCost.CompareTo(node2Compare.hCost);
        return -compare;
    }
}