using System.Collections.Generic;
using System.Linq;

public class Pathfinder
{
    public static IEnumerable<State> DepthFirstSearch(State start, State end)
    {
        int depth = 1;
        while (true)
        {
            var result = DepthFirstSearch(start, end, depth++);
            if (result != null)
            {
                return result;
            }
        }
    }

    public static IEnumerable<State> DepthFirstSearch(State start, State end, int allowedDepth)
    {
        HashSet<State> visitedNodes = new HashSet<State>();
        visitedNodes.Add(start);
        Stack<State> path = new Stack<State>();
        path.Push(start);

        while (path.Count > 0)
        {
            bool foundNextNode = false;
            foreach (var neighbor in path.Peek().GetSuccessors())
            {
                if (visitedNodes.Contains(neighbor)) continue;
                else if (allowedDepth > 0)
                {
                    visitedNodes.Add(neighbor);
                    path.Push(neighbor);
                    allowedDepth--;
                    if (neighbor.Equals(end))
                    {
                        return path.Reverse();
                    }
                    foundNextNode = true;
                    break;
                }
            }
            if (!foundNextNode)
            {
                path.Pop();
                allowedDepth++;
            }
        }
        return null;
    }

    public static IEnumerable<State> BreadthFirstSearchPath(State start, State end)
    {
        var visitedNodes = new HashSet<State>() { start };
        Queue<State[]> todoPaths = new Queue<State[]>();
        todoPaths.Enqueue(new[] { start });

        while (todoPaths.Count > 0)
        {
            var currentPath = todoPaths.Dequeue();
            State currentNode = currentPath[^1];
            foreach (var neighbor in currentNode.GetSuccessors())
            {
                if (Equals(neighbor, end))
                {
                    return currentPath.Concat(new[] { end }).ToArray();
                }
                if (!visitedNodes.Contains(neighbor))
                {
                    visitedNodes.Add(neighbor);
                    todoPaths.Enqueue(currentPath.Concat(new[] { neighbor }).ToArray());
                }
            }
        }
        return null;
    }

    public static IEnumerable<State> BreadthFirstSearchPredecessors(State startNode, State endNode)
    {
        Queue<State> todoNodes = new Queue<State>();
        todoNodes.Enqueue(startNode);
        Dictionary<State, State> predecessors = new Dictionary<State, State>();

        while (todoNodes.Count > 0)
        {
            State currentNode = todoNodes.Dequeue();
            foreach (var neighbor in currentNode.GetSuccessors())
            {
                if (neighbor.Equals(endNode))
                {
                    predecessors[neighbor] = currentNode;
                    return BuildPath(predecessors, neighbor);
                }
                else if (predecessors.ContainsKey(neighbor) || neighbor.Equals(startNode))
                {
                    continue;
                }
                else
                {
                    predecessors[neighbor] = currentNode;
                    todoNodes.Enqueue(neighbor);
                }
            }
        }
        return null;
    }

    private static IEnumerable<State> BuildPath(Dictionary<State, State> predecessors, State neighbor)
    {
        List<State> path = new List<State>();
        while (true)
        {
            path.Add(neighbor);
            if (!predecessors.TryGetValue(neighbor, out neighbor))
            {
                break;
            }
        }
        path.Reverse();
        return path;
    }
}