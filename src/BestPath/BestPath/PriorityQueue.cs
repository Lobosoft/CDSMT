using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPath
{
    public class PriorityQueue
    {
        private SortedSet<(Node, int)> queue;

        public PriorityQueue()
        {
            queue = new SortedSet<(Node, int)>(Comparer<(Node, int)>.Create((a, b) =>
                a.Item2 == b.Item2
                    ? string.Compare(a.Item1.Name, b.Item1.Name, StringComparison.Ordinal)
                    : a.Item2.CompareTo(b.Item2)));
        }

        public void Enqueue(Node node, int cost)
        {
            queue.Add((node, cost));
        }

        public (Node node, int cost) Dequeue()
        {
            var first = queue.Min;
            queue.Remove(first);
            return first;
        }

        public bool Contains(Node node)
        {
            foreach (var (n, _) in queue)
            {
                if (n.Name == node.Name)
                    return true;
            }
            return false;
        }

        public void Remove(Node node)
        {
            foreach (var item in queue)
            {
                if (item.Item1.Name == node.Name)
                {
                    queue.Remove(item);
                    break;
                }
            }
        }

        public int Count => queue.Count;
    }
}
