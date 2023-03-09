using UnityEngine;

namespace DefaultNamespace
{
    public class CellView : MonoBehaviour
    {
        public SpriteRenderer sprite;

        public void SetCell(Cell cell)
        {
            sprite.color = !cell.walkable ? Color.black : cell.visited ? Color.cyan : Color.gray;
        }
    }
}