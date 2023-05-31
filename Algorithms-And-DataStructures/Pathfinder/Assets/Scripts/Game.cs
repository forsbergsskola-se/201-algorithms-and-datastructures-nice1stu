using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Game : MonoBehaviour
{
    [SerializeField] private State state;
    public State goal;
    public event Action<State> StateChanged;

    public State State
    {
        get => state;
        set
        {
            state = value;
            StateChanged?.Invoke(value);
        }
    }

    [ContextMenu("Move Right")]
    public void MoveRight()
    {
        State current = State;
        current.playerPosition += Vector2Int.right;
        State = current;
    }
  
    [ContextMenu("Depth First Search")]
    public void DepthFirstSearch()
    {
        var path = Pathfinder.DepthFirstSearch(state, goal);
        StartCoroutine(Co_PlayPath(path));
    }
    
    IEnumerator Co_PlayPath(IEnumerable<State> path)
    {
        foreach (var state in path)
        {
            yield return new WaitForSeconds(0.5f);
            State = state;
        }
    }
    
    [ContextMenu("Breadth First Search Path")]
    public void BreadthFirstSearchPath()
    {
        var path = Pathfinder.BreadthFirstSearchPath(state, goal);
        StartCoroutine(Co_PlayPath(path));
    }



    [ContextMenu("Breadth First Search Predecessors")]
    public void BreadthFirstSearchPredecessors()
    {
        var path = Pathfinder.BreadthFirstSearchPredecessors(state, goal);
        StartCoroutine(Co_PlayPath(path));
    }
}