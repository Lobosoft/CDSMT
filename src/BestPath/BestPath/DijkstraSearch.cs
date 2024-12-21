using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BestPath
{
    internal class Dijkstra : BaseSearch
    {
        public override List<string> Search(Graph graph, string startName, string goalName)
        {
            var start = graph.GetNode(startName);
            var goal = graph.GetNode(goalName);
            if (start == null || goal == null) return new List<string> { "Invalid start or goal node" };

            // Inicialización de estructuras auxiliares
            var distances = new Dictionary<Node, int>();
            var previous = new Dictionary<Node, Node>();
            var priorityQueue = new PriorityQueue();

            // Configuración inicial
            foreach (var node in graph.Nodes)
            {
                distances[node] = int.MaxValue; // Distancia infinita inicial
                previous[node] = null;         // Sin predecesores al principio
            }
            distances[start] = 0;
            priorityQueue.Enqueue(start, 0);

            while (priorityQueue.Count > 0)
            {
                var (current, _) = priorityQueue.Dequeue();

                if (current.Name == goalName)
                {
                    return ReconstructPath(previous, current);
                }

                foreach (var (neighborName, cost) in current.Neighbors)
                {
                    var neighbor = graph.GetNode(neighborName);
                    if (neighbor == null) continue;

                    int newDistance = distances[current] + cost;

                    if (newDistance < distances[neighbor])
                    {
                        distances[neighbor] = newDistance;
                        previous[neighbor] = current;

                        if (!priorityQueue.Contains(neighbor))
                        {
                            priorityQueue.Enqueue(neighbor, newDistance);
                        }
                        else
                        {
                            priorityQueue.Remove(neighbor);
                            priorityQueue.Enqueue(neighbor, newDistance);
                        }
                    }
                }
            }

            return new List<string> { "No path found" };
        }
    }
}
