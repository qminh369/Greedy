using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    public class GraphColoring: UndirectedGraph
    {
        public GraphColoring(int v)
        {
            _vertex = v;
            _adj = new LinkedList<int>[v];
            for (int i = 0; i < v; i++)
                _adj[i] = new LinkedList<int>();
        }

        //Add an edge into the graph
        public override void addEdge(int v, int w)
        {
            _adj[v].AddLast(w);
            _adj[w].AddLast(v); 
        }

        // Assigns colors (starting from 0) to all vertices
        public void greedyColoring()
        {
            int[] _result = new int[_vertex];

            // Initialize all vertices as unassigned
            Array.Fill(_result, -1);

            // Assign the first color to first vertex
            _result[0] = 0;

            // A temporary array to store the available colors. 
            Boolean[] _available = new Boolean[_vertex];

            // Initially, all colors are available
            Array.Fill(_available, true);

            // Assign colors to remaining V-1 vertices
            for (int u = 1; u < _vertex; u++)
            {
                // Process all adjacent vertices and flag their colors as unavailable
                foreach (int i in _adj[u])
                {
                    if (_result[i] != -1)
                        _available[_result[i]] = false;
                }

                // Find the first available color
                int cr;
                for (cr = 0; cr < _vertex; cr++)
                {
                    if (_available[cr])
                        break;
                }

                _result[u] = cr; // Assign the found color

                // Reset the values back to true for the next iteration
                Array.Fill(_available, true);
            }

            for (int u = 0; u < _vertex; u++)
                Console.WriteLine("Vertex " + u + " --->  Color " + _result[u]);
        }
    }
}
