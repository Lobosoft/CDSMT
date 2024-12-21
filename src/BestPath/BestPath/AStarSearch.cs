using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPath
{
    public class AStar : BaseSearch
    {
        public override List<string> Search(Graph graph, string startName, string goalName)
        {
            var start = graph.GetNode(startName);
            var goal = graph.GetNode(goalName);
            if (start == null || goal == null) return new List<string> { "Invalid start or goal node" };

            var openSet = new PriorityQueue();
            var cameFrom = new Dictionary<Node, Node>();
            var gScore = new Dictionary<Node, int>();
            var fScore = new Dictionary<Node, int>();

            gScore[start] = 0;
            fScore[start] = start.Heuristic;
            openSet.Enqueue(start, fScore[start]);

            while (openSet.Count > 0)
            {
                var (current, _) = openSet.Dequeue();
                if (current.Name == goalName)
                    return ReconstructPath(cameFrom, current);

                foreach (var (neighborName, cost) in current.Neighbors)
                {
                    var neighbor = graph.GetNode(neighborName);
                    if (neighbor == null) continue;

                    int tentativeGScore = gScore.GetValueOrDefault(current, int.MaxValue) + cost;

                    if (tentativeGScore < gScore.GetValueOrDefault(neighbor, int.MaxValue))
                    {
                        cameFrom[neighbor] = current;
                        gScore[neighbor] = tentativeGScore;
                        fScore[neighbor] = tentativeGScore + neighbor.Heuristic;

                        if (!openSet.Contains(neighbor))
                            openSet.Enqueue(neighbor, fScore[neighbor]);
                        else
                        {
                            openSet.Remove(neighbor);
                            openSet.Enqueue(neighbor, fScore[neighbor]);
                        }
                    }
                }
            }

            return new List<string> { "No path found" };
        }
    }    
}
