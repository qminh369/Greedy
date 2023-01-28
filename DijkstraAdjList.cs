using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    public class AdjListNode : IComparable<AdjListNode>
    {
        private int _vertex;
        private int _weight;
        public AdjListNode(int v, int w)
        {
            _vertex = v;
            _weight = w;
        }

        public int Vertex { get => _vertex; set => _vertex = value; }
        public int Weight { get => _weight; set => _weight = value; }

        public int CompareTo(AdjListNode _other)
        {
            return _weight - _other._weight;
        }
    }
    class DijkstraAdjList
    {
        public int[] dijkstra(int V, List<List<AdjListNode>> _graph, int _src)
        {
            int[] _distance = new int[V];
            for (int i = 0; i < V; i++)
                _distance[i] = Int32.MaxValue;
            _distance[_src] = 0;

            SortedSet<AdjListNode> pq = new SortedSet<AdjListNode>();
            pq.Add(new AdjListNode(_src, 0));

            while (pq.Count > 0)
            {
                AdjListNode current = pq.First();
                pq.Remove(current);

                foreach (AdjListNode n in _graph[current.Vertex])
                {
                    if (_distance[current.Vertex] + n.Weight < _distance[n.Vertex])
                    {
                        _distance[n.Vertex] = n.Weight + _distance[current.Vertex];
                        pq.Add(new AdjListNode(n.Vertex, _distance[n.Vertex]));
                    }
                }
            }

            return _distance;
        }
    }
}
