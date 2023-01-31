namespace TurboCollections;

public class TurboBSTArray
{
    /*public int[] _tree;
    public int _size;
    private const int MaxSize = 10;

    public TurboBSTArray()
    {
        _tree = new int[MaxSize];
        _size = 0;
    }

    public bool Search(int value)
    {
        int index = 0;
        while (index < _size)
        {
            if (_tree[index] == value) return true;
            if (_tree[index] > value) index = 2 * index + 1;
            else index = 2 * index + 2;
        }

        return false;
    }

    public void Insert(int key)
    {
        int index = 0;
        while (index < _size)
        {
            if (_tree[index] > key) index = 2 * index + 1;
            else index = 2 * index + 2;
        }
        _tree[index] = key;
        _size++;
    }

    public void Inorder()
    {
        InorderRec(0);
    }

    private void InorderRec(int index)
    {
        if (index >= _size) return;

        InorderRec(2 * index + 1);
        Console.Write(_tree[index] + " ");
        InorderRec(2 * index + 2);
    }

    public void Delete(int key)
    {
        int index = 0;
        while (index < _size)
        {
            if (_tree[index] == key) break;
            if (_tree[index] > key) index = 2 * index + 1;
            else index = 2 * index + 2;
        }
        if (index >= _size) return;

        int leftmost = 2 * index + 2;
        while (leftmost < _size)
        {
            int right = leftmost + 1;
            if (right < _size && _tree[right] < _tree[leftmost]) leftmost = right;
            _tree[index] = _tree[leftmost];
            index = leftmost;
            leftmost = 2 * leftmost + 2;
        }

        _tree[index] = _tree[_size - 1];
        _size--;
    }*/
}
